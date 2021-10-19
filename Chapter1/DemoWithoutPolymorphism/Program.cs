using System;

namespace DemoWithoutPolymorphism
{
    class Tiger
    {
        public void Sound()
        {
            Console.WriteLine("Tigers roar.");
        }
    }
    class Dog
    {
        public void Sound()
        {
            Console.WriteLine("Dogs bark.");
        }
    }
    class Monkey
    {
        public void Sound()
        {
            Console.WriteLine("Monkeys whoop.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Sounds of the different animals.***");
            Tiger tiger = new Tiger();
            tiger.Sound();
            Dog dog = new Dog();
            dog.Sound();
            Monkey monkey = new Monkey();
            monkey.Sound();
            Console.ReadKey();
        }
    }
}
