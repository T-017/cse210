using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes Polymorphism Demo\n");

        // Test individual classes first
        Console.WriteLine("=== Testing Individual Shapes ===");

        Square square = new Square("Red", 5);
        Console.WriteLine($"Square - Color: {square.GetColor()}, Area: {square.GetArea():F2}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle - Color: {rectangle.GetColor()}, Area: {rectangle.GetArea():F2}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle - Color: {circle.GetColor()}, Area: {circle.GetArea():F2}");

        // Now demonstrate polymorphism with a List<Shape>
        Console.WriteLine("\n=== Polymorphism with List<Shape> ===");

        List<Shape> shapes = new List<Shape>();

        // Add different shapes to the same list (this is polymorphism in action)
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));
        shapes.Add(new Square("Yellow", 7.5));
        shapes.Add(new Rectangle("Purple", 2.5, 8));

        // Iterate through the list and call methods polymorphically
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }

        Console.WriteLine("\nProgram completed successfully!");
    }
}