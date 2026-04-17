using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Building
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }

    static void Main()
    {
        var buildings = new List<Building>
        {
            new Building { Name = "Library", Year = 1995 },
            new Building { Name = "School", Year = 2005 },
            new Building { Name = "Hospital", Year = 1980 },
            new Building { Name = "Mall", Year = 1999 }
        };

        var result = buildings
            .Where(b => b.Year < 2000)
            .Select(b => b.Name)
            .OrderBy(name => name);

        foreach (var name in result)
        {
            Console.WriteLine(name);
        }
    }
}