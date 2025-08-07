using System;

interface IMovable
{
    void Move(); // No body, just a rule
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();

        car.Move();         // Outputs: Car is moving
        bicycle.Move();     // Outputs: Bicycle is moving
    }
}
// This code demonstrates the use of an interface (IMovable) that defines a method (Move).
// The Car and Bicycle classes implement this interface, providing their own versions of the Move method.