using System;

class Vehicle
{
    public virtual void Move()
    {
        Console.WriteLine("Moving");
    }
}

class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Driving on the road");
    }
}

class Tram : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Driving on rails");
    }
}

class Program
{
    static void Main()
    {
        Vehicle bus = new Bus();
        Vehicle tram = new Tram();

        bus.Move();
        tram.Move();
    }
}