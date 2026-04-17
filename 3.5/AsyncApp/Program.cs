using System;
using System.Threading.Tasks;

class Program
{
    static async Task SaveToCloudAsync()
    {
        Console.WriteLine("Сохранение началось...");
        await Task.Delay(3000); // имитация задержки (3 секунды)
        Console.WriteLine("Сохранение завершено!");
    }

    static async Task Main()
    {
        var task = SaveToCloudAsync(); // запускаем, но не ждем

        Console.WriteLine("Программа продолжает работу...");

        await task; // дожидаемся завершения перед выходом
    }
}