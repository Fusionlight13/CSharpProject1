namespace gitPractice1;

public class WaypointManager
{
    // The muteable list that can be changed in the class privately.
    private readonly List<Waypoint> _waypoints = [];

    // The public list that cannot be changed with methods like Clear() and Remove(). It mirrors the private muteable list.
    public IReadOnlyList<Waypoint> Waypoints => _waypoints;

    //Adds a waypoint to the private list.
    public void Add(Waypoint ws)
    {
        _waypoints.Add(ws);
    }
    //Removes a waypoint from the private list.
    public void Remove(Waypoint ws)
    {
        _waypoints.Remove(ws);
    }
    //Clears all the waypoints from the private list. Used in the Load method of the WaypointFileService class.
    public void Clear()
    {
        _waypoints.Clear();
    }
}