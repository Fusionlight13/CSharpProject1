namespace gitPractice1;

public readonly struct Position(double x, double y, double z)
{
    public double X { get; } = x;
    public double Y { get; } = y;
    public double Z { get; } = z;

    public Position(int x, int z) : this(x:x, y: 0, z: z)
    {
    }
}