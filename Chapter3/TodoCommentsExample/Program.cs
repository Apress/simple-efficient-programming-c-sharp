using System;

namespace TodoCommentsExample
{
    class SimpleTodo
    {

        // TODO-We'll replace this method shortly.
        // Use SayHi() from the next release(Version-2.0).
        [ObsoleteAttribute("This method is obsolete.Call SayHi() instead.")]
        public void SayHello()
        {
            Console.WriteLine("Hello, Reader!");
        }

        public void SayHi()
        {
            Console.WriteLine("Hi, Reader!");
            Console.WriteLine("This is the latest method.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***TODO comments example.***");
            SimpleTodo simpleTodo = new SimpleTodo();
            simpleTodo.SayHello();
            simpleTodo.SayHi();
            Console.ReadKey();
        }
    }
}
