using System;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffe.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee Info Tool");

            Console.WriteLine("Write 'help' to list available coffee shops commands, " +
                "write 'quit' to exit the application");

            var coffeeDataProvider = new CoffeShopDataProvider();

            while (true)
            {
                var line = Console.ReadLine();
                var coffeeShops = coffeeDataProvider.LoadCoffeeShops();

                if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> available coffe shops commands");
                    foreach (var coffeeShop in coffeeShops)
                    {

                        Console.WriteLine("> Location: " + coffeeShop.Location);
                    }
                }
            }
        }
    }
}
