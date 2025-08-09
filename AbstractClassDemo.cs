using System;

namespace DCIT318_Assignment2
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }

    public static class AbstractClassDemo
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Abstract Classes and Methods ---");

            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Area of Circle (radius 5): {circle.GetArea()}");
            Console.WriteLine($"Area of Rectangle (4x6): {rectangle.GetArea()}");
        }
    }
}
