using System;

namespace PolymorphismDemo2
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


            //IAnimal animal = new Tiger();
            //animal.Sound();
            //animal = new Dog();
            //animal.Sound();
            //animal = new Monkey();
            //animal.Sound();

            //Additional discussion:
            //You cannot predict the output
            //in advance in this case.
            IAnimal animal = GetAnimal();
            animal.Sound();
            animal = GetAnimal();
            animal.Sound();
            animal = GetAnimal();
            animal.Sound();
            Console.ReadKey();
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
