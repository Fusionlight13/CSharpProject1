using System.Text.Json;

namespace gitPractice1;

using System.IO;

public class WaypointFileService
{
    public string FilePath { get; private set; } //*Might want to be able to update the FilePath in the future.
    private readonly WaypointManager _waypointManager; //Using object injection to get current class data. Could also use a ref.


    public WaypointFileService(string filePath, WaypointManager waypointManager)
    {
        FilePath = filePath;
        _waypointManager = waypointManager;
    }


    private void InitialFile()
    {
        if (!File.Exists(FilePath))
        {
            File.Create(FilePath).Close();
        }
    }
    
    //A bool function that makes sure the content has data and is not null or has whitespace.
    private bool HasData(out string content)
    {
        try
        {
            content = File.ReadAllText(FilePath);
        }
        catch (IOException)
        {
            Console.WriteLine($"Failed to read file {FilePath}");
            throw;
        }

        return !string.IsNullOrWhiteSpace(content);
    }

    /*
     *Function checks if the initial file exists. It creates it if it doesn't
     *If the local list is empty, it exists out.
     *The try attempts to serialize the waypoint object from the WaypointManager class
     * It writes it to the file from the path set by the user from the constructor
     *Both writing and serialization each have their own error handlers.
     * 
     * 
     */
    public void Save()
    {
        InitialFile();

        if (_waypointManager.Waypoints.Count == 0)
            throw new InvalidOperationException("No waypoints exist locally.");
        try
        {
            var jsonObject = JsonSerializer.Serialize(
                _waypointManager.Waypoints,
                new JsonSerializerOptions { WriteIndented = true }
            );
            File.WriteAllText(FilePath, jsonObject);
        }
        catch (Exception ex) when (ex is JsonException or IOException)
        {
            Console.WriteLine($"Save failed: {ex.Message}");
            throw;
        }

        Console.WriteLine($"Successfully saved {_waypointManager.Waypoints.Count} waypoints.");
    }
    
    
    /*Function checks if the initial file exists. It creates it if it doesn't.
     *HasData() returns a bool if the file is not empty. It has an out parameter for content.
     *A new temp list is made that gets the serialized json object that is loaded from the text file.
     *If the list is empty after deserialization, the process fails and raises an exception.
     * The local list needs to be cleared and rebuilt.
     * Instead of setters, I use the temporary list to append each one using the Add() method in the WaypointManager class.
     * 
     */
    
    public void Load()
    {
        InitialFile();
        if (!HasData(out var content))
            throw new InvalidOperationException("No data found");

        List<Waypoint>? waypoints;
        try
        {
            waypoints = JsonSerializer.Deserialize<List<Waypoint>>(content);
        }
        catch (JsonException e)
        {
            Console.WriteLine(e.Message);
            throw;
        }

        if (waypoints == null)
            throw new InvalidOperationException("Could not deserialize waypoints");

        _waypointManager.Clear();
        foreach (var waypoint in waypoints)
        {
            _waypointManager.Add(waypoint);
        }
    }
}