using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, double> areas = new Dictionary<string, double>()
        {
            { "Square", 1600 },
            { "Rectangle", 1200.5 },
            { "Circle", 785.4 }
        };

        Console.Write("Enter object name: ");
        string name = Console.ReadLine();

        if (areas.ContainsKey(name))
        {
            Console.WriteLine($"Area: {areas[name]}");
        }
        else
        {
            Console.WriteLine("Object not found.");
        }
    }
}