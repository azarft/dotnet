using System;

class Program
{
    static void Main()
    {
        double[] areas = { 120.5, 85.3, 200.0, 150.7, 95.4, 180.2 };

        int maxIndex = 0;

        for (int i = 1; i < areas.Length; i++)
        {
            if (areas[i] > areas[maxIndex])
            {
                maxIndex = i;
            }
        }

        Console.WriteLine("Индекс самого большого объекта: " + maxIndex);
        Console.WriteLine("Площадь самого большого объекта: " + areas[maxIndex]);
    }
}
