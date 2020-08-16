using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffee.DataAccess.Model
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 107 };
            yield return new CoffeeShop { Location = "Freigurg", BeansInStockInKg = 23 };
            yield return new CoffeeShop { Location = "Munich", BeansInStockInKg = 56 };

        }
    }
}
