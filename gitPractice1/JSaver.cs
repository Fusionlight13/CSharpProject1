using System.Text.Json;

namespace gitPractice1;

using System.IO;


public class JSaver(WayPointManager wayPointManager)
{
    
    private readonly WayPointManager _wayPointManager = wayPointManager;


    public void Save()
    {
        var json = JsonSerializer.Serialize(_wayPointManager);
        
        Console.WriteLine(json.ToString());
    }
    
    
    
    
    
        
   
    
    
}