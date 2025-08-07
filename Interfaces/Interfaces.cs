using System;

abstract class Shape
{
    public abstract double GetArea(); // No body - just a rule
}

class Circle : Shape
{
    public double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Interfaces
{
    static void Main()
    {
        Circle circle = new Circle(5); // radius = 5
        Rectangle rectangle = new Rectangle(4, 6); // width = 4, height = 6

        Console.WriteLine("Circle Area: " + circle.GetArea());
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
    }
}
// The code demonstrates the use of abstract classes and methods in C#.
// The Shape class is abstract and defines a rule for calculating area.