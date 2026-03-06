using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("Red", 10);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        Rectangle rectangle = new Rectangle("Blue", 5, 10);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());
        Circle circle = new Circle("Green", 10);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Red", 10));
        shapes.Add(new Rectangle("BLue", 5, 10));
        shapes.Add(new Circle("Green", 10));

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}