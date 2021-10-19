using System;

namespace Demo1Modified
{
    class Rectangle
    {
        readonly double length;
        readonly double breadth; 
        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        
        public double RectangleArea()
        {
            return length * breadth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Measuring the area of a rectangle.***");
            Rectangle rectangleObject = new Rectangle(2.5, 10);
            double area = rectangleObject.RectangleArea();
            Console.WriteLine($"The area of the rectangle is: {area} square units.");
            Console.ReadKey();
        }
    }
}
