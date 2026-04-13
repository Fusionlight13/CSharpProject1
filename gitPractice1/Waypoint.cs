namespace gitPractice1;

public class Waypoint(string name, string description, Position position)
{
    public string Name { get; } = name;
    public string Description { get; } = description;
    public Position Position { get; } = position;
}