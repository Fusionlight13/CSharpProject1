namespace gitPractice1;

// Position is a struct that gets the x, y, and z coords
// Y is optional which can be overridden and set to 0.
// Only the X and Z coordinates really matter for exact location.
public readonly struct Position(double x, double y, double z)
{
    public double X { get; } = x;
    public double Y { get; } = y;
    public double Z { get; } = z;

    public Position(int x, int z) : this(x: x, y: 0, z: z)
    {
    }
}