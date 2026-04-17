using System;

class Building
{
    private int floorsCount;

    public int FloorsCount
    {
        get { return floorsCount; }
        set
        {
            if (value >= 1 && value <= 100)
                floorsCount = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Building b = new Building();
        b.FloorsCount = 50;
        Console.WriteLine(b.FloorsCount);
    }
}