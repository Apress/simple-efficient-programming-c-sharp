using System;


namespace Demonstration1
{
    /// <summary>
    /// This is the Rectangle class
    /// </summary>
    class Rectangle
    {
        readonly double l; // length of the rectangle
        readonly double b; // breadth of the rectangle  
        public Rectangle(double le, double br)
        {
            l = le;
            b = br;
        }
        // Measuring the area
        public double Area()
        {
            return l * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Measuring the area of a rectangle.***");
            Rectangle r = new Rectangle(2.5, 10);
            double area = r.Area();
            Console.WriteLine($"The area of the rectangle is {area} square units.");

            Console.ReadKey();
        }
    }
}
