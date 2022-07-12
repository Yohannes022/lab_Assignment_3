using System;

namespace Program
{
    abstract class Shape
    {
        public abstract double calculateArea();
        public abstract double calculatePerimeter();
    } 

    class Circle : Shape
    {
        static readonly double PI = 3.14;
        public double Radius { get; set; }

        public override double calculateArea()
        {
            return PI * Radius * Radius;
        }

        public override double calculatePerimeter()
        {
            return 2 * PI * Radius;
        }
    }

    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override double calculateArea()
        {
            return Length * Width;
        }

        public override double calculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
    class Lab3
    {
        static void Main()
        {
            Circle circle = new Circle();
            Rectangle rect = new Rectangle();
            
            Console.WriteLine("Enter radius");
            circle.Radius = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter Width");
            rect.Width = Convert.ToDouble( Console.ReadLine());
            
            Console.WriteLine("Enter Length");
            rect.Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Radius: " + circle.Radius + "\nArea: " + circle.calculateArea());
            Console.WriteLine("\nLength; " + rect.Length + "\nWidth: " + rect.Width + "\n" +
                              "Area: " + rect.calculateArea() + "\nPerimeter: " + rect.calculatePerimeter());

        }
    }
}