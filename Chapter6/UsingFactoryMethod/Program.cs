using System;

namespace UsingFactoryMethod
{
    #region Animal hierarchy
    interface IAnimal
    {
        void DisplayBehavior();
    }
    class Tiger : IAnimal
    {
        public Tiger(string color)
        {
            Console.WriteLine($"\nA {color} tiger is created.");
        }
        public void DisplayBehavior()
        {
            Console.WriteLine("It roars.");
            Console.WriteLine("It loves to roam in a jungle.");
        }
    }
    class Cat : IAnimal
    {
        public Cat(string color)
        {
            Console.WriteLine($"\nA {color} cat is created.");
        }
        public void DisplayBehavior()
        {
            Console.WriteLine("It meows.");
            Console.WriteLine("It loves to stay at a home.");
        }
    }
    #endregion

    #region Factory hierarchy
    abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal(string color);
    }
    class CatFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal(string color)
        {
            return new Cat(color);
        }
    }
    class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal(string color)
        {
            return new Tiger(color);
        }
    }
    #endregion
   
    // Client
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Modifying demonstration 2 now.***");
            // The CatFactory creates cats
            AnimalFactory animalFactory = new CatFactory();
            IAnimal animal = animalFactory.CreateAnimal("black");
            animal.DisplayBehavior();

            // The TigerFactory creates tigers
            animalFactory = new TigerFactory();
            animal = animalFactory.CreateAnimal("white");
            animal.DisplayBehavior();

            Console.ReadKey();
        }
    }
}

