using System;

namespace UsingSimpleFactory
{
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

    class AnimalFactory
    {
        public IAnimal CreateAnimal(string animalType)
        {
            IAnimal animal;
            if (animalType.Equals("cat"))
            {
                animal = new Cat();
            }
            else if (animalType.Equals("tiger"))
            {
                animal = new Tiger();
            }
            else
            {
                Console.WriteLine("You can create either a cat or a tiger. ");
                throw new ApplicationException("Unknown animal cannot be instantiated.");
            }
            return animal;
        }
    }

    class Program
    {        
        //static void Main(string[] args)
        static void Main()
        {
            Console.WriteLine("***Creating animals and learning about them.***");
            AnimalFactory animalFactory = new AnimalFactory();
           
            IAnimal animal = animalFactory.CreateAnimal("cat");
            animal.DisplayBehavior();

            animal = animalFactory.CreateAnimal("tiger");
            animal.DisplayBehavior();

            Console.ReadKey();
        }
    }
}

