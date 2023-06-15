using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s = new Square("blue", 4);
        shapes.Add(s);
        Rectangle r = new Rectangle("red", 4, 6);
        shapes.Add(r);
        Circle c = new Circle("green", 8);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}