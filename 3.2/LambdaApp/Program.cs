using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // список площадей квадратов
        List<int> squares = new List<int> { 100, 400, 900, 1600, 2500, 3600 };

        // найти все площади больше 1000
        List<int> result = squares.FindAll(x => x > 1000);

        Console.WriteLine("Areas greater than 1000:");
        foreach (int area in result)
        {
            Console.WriteLine(area);
        }
    }
}