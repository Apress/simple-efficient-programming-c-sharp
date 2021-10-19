using System;

namespace PolymorphismDemo3
{
    interface IAnimal
    {
        void Sound();
    }
    class Tiger : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Tigers roar.");
        }
    }
    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Dogs bark.");
        }
    }
    class Monkey : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Monkeys whoop.");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("***Sounds of the different animals.***");           
            IAnimal animal = GetAnimal();
            //animal.Sound();
            MakeSound(animal);
            animal = GetAnimal();
            //animal.Sound();
            MakeSound(animal);
            animal = GetAnimal();
            //animal.Sound();
            MakeSound(animal);
            Console.ReadKey();
        }

        private static void MakeSound(IAnimal animal)
        {
            animal.Sound();
        }

        private static IAnimal GetAnimal()
        {
            IAnimal animal;
            Random random = new Random();
            //Get a number between 0 and 3(exclusive)
            int temp = random.Next(0, 3);

            if (temp == 0)
            {
                animal = new Tiger();
            }
            else if (temp == 1)
            {
                animal = new Dog();
            }
            else
            {
                animal = new Monkey();
            }
            return animal;
        }
    }
}

