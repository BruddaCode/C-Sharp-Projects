using System;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to your new business!");
        Console.WriteLine("What is the name of your business?");

        // Get business name
        string businessName = Console.ReadLine();

        // Set starting money
        decimal money = 1000.00m;

        // Main game loop
        while (true)
        {
            // Print current money
            Console.WriteLine($"You have ${money}.");

            // Get user input
            Console.WriteLine("What would you like to do? (buy [product], sell [product], or quit)");
            string input = Console.ReadLine();

            // Quit if user types "quit"
            if (input == "quit")
            {
                break;
            }

            // Get product name
            string productName = input.Substring(input.IndexOf(' ') + 1);

            // Get product price
            decimal productPrice = 0.00m;
            switch (productName)
            {
                case "computer":
                    productPrice = 800.00m;
                    break;
                case "phone":
                    productPrice = 600.00m;
                    break;
                case "television":
                    productPrice = 1200.00m;
                    break;
                default:
                    Console.WriteLine($"Sorry, we don't sell {productName}.");
                    continue;
            }

            // Buy or sell product
            if (input.StartsWith("buy"))
            {
                // Check if user can afford product
                if (money < productPrice)
                {
                    Console.WriteLine($"Sorry, you can't afford to buy a {productName}.");
                    continue;
                }

                // User buys product
                money -= productPrice;
                Console.WriteLine($"You bought a {productName}.");
            }
            else if (input.StartsWith("sell"))
            {
                // User sells product
                money += productPrice;
                Console.WriteLine($"You sold a {productName}.");
            }
        }
    }
}