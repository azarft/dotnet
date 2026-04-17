using System;
using System.IO;
using System.Text.Json;

class Program
{
    class Territory
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int Population { get; set; }
    }

    static void Main()
    {
        var territory = new Territory
        {
            Name = "Bishkek Region",
            Area = 200,
            Population = 1000000
        };

        // Сохранение в файл
        string json = JsonSerializer.Serialize(territory, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("myterritory.json", json);

        Console.WriteLine("Сохранено в файл!");

        // Загрузка из файла
        string loadedJson = File.ReadAllText("myterritory.json");
        var loadedTerritory = JsonSerializer.Deserialize<Territory>(loadedJson);

        Console.WriteLine("Загружено из файла:");
        Console.WriteLine($"{loadedTerritory.Name}, {loadedTerritory.Area}, {loadedTerritory.Population}");
    }
}