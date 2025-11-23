using System;

public class Point
{
    public int X;
    public int Y;

    public static readonly Point Zero = new Point(0, 0);

    public Point(int x, int y)
    {
        X = x; Y = y;
    }

    public override string ToString() => $"({X},{Y})";
}
