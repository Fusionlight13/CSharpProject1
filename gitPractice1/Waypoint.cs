namespace gitPractice1;

public class Waypoint(string name, string description, Position position)
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public Position Position { get; set; } = position;
}