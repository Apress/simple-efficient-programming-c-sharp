using System;

namespace DiamondProblem
{
    class Shape
    {
        public virtual void AboutMe()
        {
            Console.WriteLine("It is an arbitrary Shape.");
        }
    }
    class Triangle : Shape
    {
        public override void AboutMe()
        {
            Console.WriteLine("It is a Triangle.");
        }
    }
    class Rectangle : Shape
    {
        public override void AboutMe()
        {
            Console.WriteLine("It is a Rectangle");
        }
    }

    //class GrandShape : Triangle, Rectangle //Error: Diamond Effect
    //{
    //    //Some  code
    //}


    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Diamond problem demo.***");
            Console.ReadKey();
        }
    }
}
