using System;

class Citizen
{
    public string Name;
    public int Age;
    public string District;

    public void ShowInfo()
    {
        Console.WriteLine("Имя: " + Name);
        Console.WriteLine("Возраст: " + Age);
        Console.WriteLine("Район: " + District);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Citizen citizen1 = new Citizen();
        citizen1.Name = "Алексей";
        citizen1.Age = 25;
        citizen1.District = "Центральный";

        Citizen citizen2 = new Citizen();
        citizen2.Name = "Мария";
        citizen2.Age = 30;
        citizen2.District = "Южный";

        citizen1.ShowInfo();
        citizen2.ShowInfo();
    }
}
