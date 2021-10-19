using System;

namespace ImprovedVersion
{
    class SuperGame
    {
        readonly string companyName;
        readonly string gameName;
        readonly double minimumAge;
        readonly string version;
        readonly double actualCost;
        readonly double discountedCost;
        public SuperGame()
        {
            companyName = "AbcCompany";
            gameName = "SuperGame";
            version = "1.0";
            minimumAge = 10;
            actualCost = 1000;            
            discountedCost = 800;
        }
        public void AboutGame()
        {
            Console.WriteLine($"Game name: {gameName}");
            Console.WriteLine($"Minimum age: {minimumAge} years and above.");
            Console.WriteLine($"Current version: {version}.");
            Console.WriteLine($"It is a {companyName} product.");
        }
        public void DisplayCost()
        {
            Console.WriteLine($"\n{companyName} SuperGame's price details:");
            Console.WriteLine($"Version:{version} " +
                              $"cost is:{actualCost}");
        }
        public void DisplayCostAfterDiscount()
        {
            Console.WriteLine($"\n{companyName} offers a festive season discount.");
            Console.WriteLine("Discounted price detail:");
            Console.WriteLine($"Game: {gameName}. " +
                              $"Version: {version}. " +
                              $"Discounted price:{discountedCost}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("***An improved version using DRY principle.***");
            SuperGame superGame = new SuperGame();
            superGame.AboutGame();
            superGame.DisplayCost();
            superGame.DisplayCostAfterDiscount();
            Console.ReadKey();
        }
    }
}
