namespace gitPractice1;

public class WayPointManager
{
    
    private readonly List<Waypoint> _waypoints = [];
    
    public IReadOnlyList<Waypoint> Waypoints => _waypoints;
    

    public void Add(Waypoint ws)
    {
        _waypoints.Add(ws);
    }
    
    public void Remove(Waypoint ws)
    {
        _waypoints.Remove(ws);
    }
    
    
    
}