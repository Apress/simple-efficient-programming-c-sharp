using System;

namespace UnderstandingLSP
{
   class Rectangle
    {
        protected double length, breadth;
        public Rectangle(double length, 
                         double breadth=2)
        {
            this.length = length;
            this.breadth = breadth;
            Console.WriteLine($"Length = {length} units.");
            Console.WriteLine($"Breadth = {breadth} units.");
        }
        public virtual void ShowArea()
        {
            Console.WriteLine($"Area = {length * breadth} sq. units.");
            Console.WriteLine("----------");
        }

    }
    class Square : Rectangle
    {
        public Square(double length) :
            base(length)
        {
        }
        public override void ShowArea()
        {
            Console.WriteLine($"Area = {length*length} sq. units.");
            Console.WriteLine("----------");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Understanding LSP.***");

            Console.WriteLine("Rectangle-1:");

            Rectangle rectangle = new Rectangle(10, 5.5);
            rectangle.ShowArea();

            Console.WriteLine("Rectangle-2:");
            rectangle = new Rectangle(25);
            rectangle.ShowArea();

            Console.WriteLine("Rectangle-3:");
            rectangle = new Square(25);
            rectangle.ShowArea();            

            Console.ReadKey();
        }
    }
}
