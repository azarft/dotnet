using System;

class MyClass
{
    public int Value;
}

class Program
{
    static void Main()
    {
        // Array of 1000 numbers
        int[] numbers = new int[1000];

        // Array of 1000 class objects
        MyClass[] objects = new MyClass[1000];

        for (int i = 0; i < 1000; i++)
        {
            objects[i] = new MyClass();
            objects[i].Value = i;
        }

        Console.WriteLine("Arrays created.");
    }
}
