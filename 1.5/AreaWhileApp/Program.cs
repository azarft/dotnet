using System;

class Program
{
    static void Main()
    {
        double sum = 0;

        while (true)
        {
            Console.Write("Введите площадь участка (0 для выхода): ");
            double area = Convert.ToDouble(Console.ReadLine());

            if (area == 0)
                break;

            sum += area;
        }

        Console.WriteLine("Общая площадь: " + sum);
    }
}
