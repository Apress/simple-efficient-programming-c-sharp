using System;

namespace SimpleFactoryModified
{
    #region Animal hierarchy
    interface IAnimal
    {
        void DisplayBehavior();
    }
    class Tiger : IAnimal
    {
        public Tiger()
        {
            Console.WriteLine("\nA tiger is created.");
        }
        public void DisplayBehavior()
        {
            Console.WriteLine("It roars.");
            Console.WriteLine("It loves to roam in a jungle.");
        }
    }
    class Cat : IAnimal
    {
        public Cat()
        {
            Console.WriteLine("\nA cat is created.");
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
        public abstract IAnimal CreateAnimal();        
    }
    class CatFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
    class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Tiger();
        }
    }
    #endregion

    // Client
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Modifying the simple factory in the demonstration 1.***");
            // The CatFactory creates cats
            AnimalFactory animalFactory = new CatFactory();
            IAnimal animal = animalFactory.CreateAnimal();
            animal.DisplayBehavior();

            //The TigerFactory creates tigers
            animalFactory = new TigerFactory(); 
            animal = animalFactory.CreateAnimal();
            animal.DisplayBehavior();

            Console.ReadKey();
        }
    }
}

