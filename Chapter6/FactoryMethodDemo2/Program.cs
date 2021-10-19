using System;

namespace FactoryMethodDemo2
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
    abstract class AbstractAnimalFactory
    {
        public IAnimal MakeAnimal(string color)
        {
            Console.WriteLine($"\nThe following animal color is {color}.");
            IAnimal animal= CreateAnimal();
            return animal;
        }
        public abstract IAnimal CreateAnimal();
    }
    class CatFactory : AbstractAnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
    class TigerFactory : AbstractAnimalFactory
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
            Console.WriteLine("***Modifying demonstration 2 now.***");
            // The CatFactory creates cats
            AbstractAnimalFactory animalFactory = new CatFactory();            
            IAnimal animal = animalFactory.MakeAnimal("black");
            animal.DisplayBehavior();

            //The TigerFactory creates tigers
            animalFactory = new TigerFactory();            
            animal = animalFactory.MakeAnimal("white");
            animal.DisplayBehavior();

            Console.ReadKey();
        }
    }
}

