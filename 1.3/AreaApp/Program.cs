using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите площадь участка (м²): ");
        double area = Convert.ToDouble(Console.ReadLine());

        Console.Write("Есть вода? (true/false): ");
        bool water = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Есть газ? (true/false): ");
        bool gas = Convert.ToBoolean(Console.ReadLine());

        if (area > 1000 || (water && gas))
        {
            Console.WriteLine("Участок подходит");
        }
        else
        {
            Console.WriteLine("Участок не подходит");
        }
    }
}
