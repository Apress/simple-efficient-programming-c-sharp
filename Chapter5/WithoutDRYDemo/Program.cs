using System;

namespace WithoutDRYDemo
{
    class SuperGame
    {
        public void AboutGame()
        {
            Console.WriteLine("Game name: SuperGame");            
            Console.WriteLine("Minimum age: 10 years and above.");
            Console.WriteLine("Current version: 1.0.");
            Console.WriteLine("It is a AbcCompany product.");                    
        }
        
        public void DisplayCost()
        {
            Console.WriteLine("\nAbcCompany SuperGame's price details:");
            Console.WriteLine("Version:1.0 cost is:$1000");            
        }       
        public void DisplayCostAfterDiscount()
        {
            Console.WriteLine("\nAbcCompany offers a festive season discount.");
            Console.WriteLine("Discounted price detail:");            
            Console.WriteLine("Game: SuperGame. Version: 1.0. Discounted price:$800");
        }        
       
    }
    

    class Program
    {
        static void Main()
        {
            Console.WriteLine("***A demo without DRY principle.***");
            SuperGame superGame = new SuperGame();
            superGame.AboutGame();
            superGame.DisplayCost();
            superGame.DisplayCostAfterDiscount();
            Console.ReadKey();
        }
    }
}
