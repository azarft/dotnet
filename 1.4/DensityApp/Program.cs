using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите плотность населения (чел/км²): ");
        double density = Convert.ToDouble(Console.ReadLine());

        if (density < 100)
        {
            Console.WriteLine("Низкая");
        }
        else if (density <= 500)
        {
            Console.WriteLine("Средняя");
        }
        else
        {
            Console.WriteLine("Высокая");
        }
    }
}
