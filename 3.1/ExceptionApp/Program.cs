using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try {
            ReadMapFile("map.txt");
        }
         catch (Exception e) 
        {
            Console.WriteLine("Вот я поймал exception после throw");
        }
    }

    static void ReadMapFile(string filePath)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("Map loaded successfully:");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Sorry, the map file was not found. Please check the file path.");
            throw new Exception("Hello bro");
        }
       
    }
}