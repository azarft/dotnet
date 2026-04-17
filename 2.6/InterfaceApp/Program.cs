using System;
using System.Collections.Generic;

interface ICalculateArea
{
    double GetArea();
}

class SquarePlot : ICalculateArea
{
    public double Side;

    public SquarePlot(double side)
    {
        Side = side;
    }

    public double GetArea()
    {
        return Side * Side;
    }
}

class TrianglePlot : ICalculateArea
{
    public double Base;
    public double Height;

    public TrianglePlot(double b, double h)
    {
        Base = b;
        Height = h;
    }

    public double GetArea()
    {
        return 0.5 * Base * Height;
    }
}

class Program
{
    static void Main()
    {
        List<ICalculateArea> plots = new List<ICalculateArea>
        {
            new SquarePlot(4),
            new TrianglePlot(3, 6)
        };

        foreach (var plot in plots)
        {
            Console.WriteLine(plot.GetArea());
        }
    }
}