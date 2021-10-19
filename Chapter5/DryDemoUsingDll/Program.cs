using BasicGameInfo;
using System;


namespace DryDemoUsingDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Apply the DRY principle using DLLs. ***");

            // Initial setup
            GameInfo  gameInfo = new GameInfo("NewPokemonKid");

            GamePrice gamePrice = new GamePrice();

            // Create the game instance with default setup
            Game game = new Game(gameInfo,gamePrice);

            // Display the default game detail.
            game.AboutGame();
            game.DisplayCost();
            game.DisplayCostAfterDiscount();

            Console.WriteLine("------------");

            Console.WriteLine("Changing the game version and price now.");

            // Changing some of the game info
            gameInfo.Version = "2.1";
            gameInfo.MinimumAge = 12.5;

            // Changing the game cost
            gamePrice.Cost = 3500;
            gamePrice.DiscountedCost = 2000;

            // Updating the game instance
            game = new Game(gameInfo, gamePrice);

            // Display the latest detail
            game.AboutGame();
            game.DisplayCost();
            game.DisplayCostAfterDiscount();

            Console.ReadKey();
        }
    }
}

