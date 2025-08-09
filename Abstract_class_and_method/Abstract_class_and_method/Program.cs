using System.Security.Cryptography.X509Certificates;

namespace Abstract_class_and_method
{
    //Abstract class
    public abstract class Shape
    {
        public abstract double getArea(); // Abstract method
    }

    // Derived class
    public class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        // Implementing the abstract method
        public override double getArea()
        {
            return Math.PI * radius * radius;
        }
    }
    public class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        // Implementing the abstract method
        public override double getArea()
        {
            return length * width;
        }
    }
    // Main program
    internal class Program
    {
        private static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Console.WriteLine($"Area of Circle: {circle.getArea()}");
            Shape rectangle = new Rectangle(4, 5);
            Console.WriteLine($"Area of Rectangle: {rectangle.getArea()}");
        }
    }
}