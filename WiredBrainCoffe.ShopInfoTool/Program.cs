using System;
using System.Linq;
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
                else
                {
                    var foundCoffeShops = coffeeShops
                        .Where(cf => cf.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    if (foundCoffeShops.Count == 0)
                    {
                        Console.WriteLine("Not found");
                    }
                    else if (foundCoffeShops.Count == 1)
                    {
                        var coffeShop = foundCoffeShops.Single();
                        Console.WriteLine($"> command  {line} { coffeShop.Location}");
                        Console.WriteLine($"> command  {line} { coffeShop.BeansInStockInKg}");
                    }
                    else
                    {
                        foreach (var coffeeShop in foundCoffeShops)
                        {
                            Console.WriteLine($"> command  {line} { coffeeShop.Location}");
                        }
                    }
                }
            }
        }
    }
}
