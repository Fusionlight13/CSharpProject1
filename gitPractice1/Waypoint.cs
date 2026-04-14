namespace gitPractice1;

/*
 * Simple properties for getting the 3 main attributes.
 * Name and Description are simple string properties
 *  Position is a struct that gets the x, y, and z coords
 */

public class Waypoint(string name, string description, Position position)
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = description;
    public Position Position { get; set; } = position;
}