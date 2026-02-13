using System;

class Program
{
    static void UpdatePopulation(ref int currentPopulation, int growth)
    {
        currentPopulation += growth;
    }

    static void Main()
    {
        int population = 1000;

        Console.WriteLine("Before update: " + population);

        UpdatePopulation(ref population, 200);

        Console.WriteLine("After update: " + population);
    }
}
