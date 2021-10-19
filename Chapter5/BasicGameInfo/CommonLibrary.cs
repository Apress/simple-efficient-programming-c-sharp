using System;

namespace BasicGameInfo
{
    public class Game
    {
        readonly string companyName;
        readonly string gameName;
        readonly double minimumAge;
        readonly string version;
        readonly double actualCost;
        readonly double discountedCost;
        public Game(
                GameInfo gameInfo,
                GamePrice gamePrice
                )
        {
            companyName = gameInfo.CompanyName;
            gameName = gameInfo.GameName;
            version = gameInfo.Version;
            minimumAge = gameInfo.MinimumAge;
            actualCost = gamePrice.Cost;
            discountedCost = gamePrice.DiscountedCost;
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
            Console.WriteLine($"\n{companyName} {gameName}'s price details:");
            Console.WriteLine($"Version:{version},cost:${actualCost}");
        }
        public void DisplayCostAfterDiscount()
        {
            Console.WriteLine($"\n{companyName} offers a festive season discount.");
            Console.WriteLine("Discounted price detail:");
            Console.WriteLine($"Game: {gameName},Version: {version},Discounted price:${discountedCost}");
        }
    }

    public class GameInfo
    {
        public string CompanyName { get; set; }
        public string GameName { get; set; }
        public string Version { get; set; }
        public double MinimumAge { get; set; }
        public GameInfo(string gameName)
        {
            CompanyName = "Sony";
            GameName = gameName;
            Version = "1.0";
            MinimumAge = 10.5;
        }
    }
    public class GamePrice
    {
        public double Cost { get; set; }
        public double DiscountedCost { get; set; }

        public GamePrice()
        {
            Cost = 1000;
            DiscountedCost = 800;
        }
    }
}
