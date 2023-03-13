using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("red", 3);
        shapes.Add(square);

        Circle newCircle = new Circle("blue", 60);
        shapes.Add(newCircle);

        Square newSquare = new Square("orange", 12);
        shapes.Add(newSquare);

        Rectangle rectangle = new Rectangle("green", 6, 3);
        shapes.Add(rectangle);

        Circle circle = new Circle("yellow", 1);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.Color} {shape.Type} has an area of {shape.GetArea()}");
        }
        
    }
}