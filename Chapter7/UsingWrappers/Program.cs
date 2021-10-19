using System;

namespace UsingWrappers
{
    abstract class Home
    {
        public double basePrice = 100000;
        public double AdditionalCost { get; set; }
        public abstract void BuildHome();
        public virtual double GetPrice()
        {
            return basePrice + AdditionalCost;
        }
    }
    class BasicHome : Home
    {
        public BasicHome()
        {
            AdditionalCost = 0;
        }
        public override void BuildHome()
        {
            Console.WriteLine("A home with basic facilities is made.");
            Console.WriteLine($"It costs ${GetPrice()}.");
        }      
    }

    class AdvancedHome : Home
    {
        public AdvancedHome()
        {
            AdditionalCost = 25000;
        }
        public override void BuildHome()
        {
            Console.WriteLine("A home with advanced facilities is made.");
            Console.WriteLine($"It costs ${GetPrice()}.");
        }        
    }
    abstract class Luxury : Home
    {
        protected Home home;
        public double LuxuryCost { get; set; }
        public Luxury(Home home)
        {
            this.home = home;
        }
        public override void BuildHome()
        {
            home.BuildHome();
        }        
    }
    class PlayGround : Luxury
    {
        public PlayGround(Home home) : base(home)
        {
            this.LuxuryCost = 20000;
        }
        public override void BuildHome()
        {
            base.BuildHome();
            AddPlayGround();
        }

        private void AddPlayGround()
        {
            Console.WriteLine($"For a playground, you pay an extra ${this.LuxuryCost}.");
            Console.WriteLine($"Now the total cost is ${GetPrice()}.");
        }
        public override double GetPrice()
        {
            return home.GetPrice() + LuxuryCost;
        }
    }

    class SwimmingPool : Luxury
    {
        public SwimmingPool(Home home) : base(home)
        {
            this.LuxuryCost = 55000;
        }
        public override void BuildHome()
        {
            base.BuildHome();
            AddSwimmingPool();
        }

        private void AddSwimmingPool()
        {
            Console.WriteLine($"For a swimming pool, you pay an extra ${this.LuxuryCost}.");
            Console.WriteLine($"Now the total cost is ${GetPrice()}.");
        }
        public override double GetPrice()
        {
            return home.GetPrice() + LuxuryCost;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Using wrappers.***");
            Console.WriteLine("Scenario-1: A basic home with basic facilities.");
            Home home = new BasicHome();
            home.BuildHome();

            Console.WriteLine("\nScenario-2: A basic home with an additional playground.");
            Luxury homeWithOnePlayGround = new PlayGround(home);
            homeWithOnePlayGround.BuildHome();

            Console.WriteLine("\nScenario-3: A basic home with two additional playgrounds.");
            Luxury homeWithDoublePlayGrounds = new PlayGround(homeWithOnePlayGround);
            homeWithDoublePlayGrounds.BuildHome();

            Console.WriteLine("\nScenario-4: A basic home with one additional playground and swimming pool.");
            Luxury homeWithOnePlayGroundAndOneSwimmingPool = new SwimmingPool(homeWithOnePlayGround);
            homeWithOnePlayGroundAndOneSwimmingPool.BuildHome();

            Console.WriteLine("\nScenario-5: Adding a swimming pool and then a playground to the basic home.");
            Luxury homeWithOneSimmingPool = new SwimmingPool(home);
            Luxury homeWithSwimmingPoolAndPlayground = new PlayGround(homeWithOneSimmingPool);
            homeWithSwimmingPoolAndPlayground.BuildHome();

            Console.WriteLine("\nScenario-6: An advanced home with some more facilities.");
            home = new AdvancedHome();
            home.BuildHome();

            Console.WriteLine("\nScenario-7: An advanced home with an additional playground.");
            homeWithOnePlayGround = new PlayGround(home);
            homeWithOnePlayGround.BuildHome();           

            Console.ReadKey();
        }
    }
}
