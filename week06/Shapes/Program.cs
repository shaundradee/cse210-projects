using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 5);
        shapes.Add(s1);
        Console.WriteLine(s1.GetColor());
        Console.WriteLine(s1.GetArea());

        Rectangle r1 = new Rectangle("Yellow", 5, 8);
        shapes.Add(r1);
        Console.WriteLine(r1.GetColor());
        Console.WriteLine(r1.GetArea());

        Circle c1 = new Circle("Green", 9);
        shapes.Add(c1);
        Console.WriteLine(c1.GetColor());
        Console.WriteLine(c1.GetArea());

        foreach (Shape s in shapes)
        {
            Console.WriteLine("\n");
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }

    }
}