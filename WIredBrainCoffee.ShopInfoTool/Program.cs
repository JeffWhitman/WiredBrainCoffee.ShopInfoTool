using System;
using WiredBrainCoffee.DataAccess.Model;

namespace WIredBrainCoffee.ShopInfoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");

            Console.WriteLine("Write 'help' to list available coffee shop commands");

            var coffeeDataShopDataProvider = new CoffeeShopDataProvider();

            while(true)
            {
                var line = Console.ReadLine();

                var coffeeShops = coffeeDataShopDataProvider.LoadCoffeeShops();

                if(String.Equals("help",line,StringComparison.OrdinalIgnoreCase))
                {                       
                    Console.WriteLine("> Available coffee shop commands:");

                    foreach(var coffeeShop in coffeeShops)
                    {
                        Console.WriteLine($"> " + coffeeShop.Location);
                    }

                }
            }

        }
    }
}
