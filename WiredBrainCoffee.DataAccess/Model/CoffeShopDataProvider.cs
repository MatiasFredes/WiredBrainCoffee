using System.Collections.Generic;

namespace WiredBrainCoffee.DataAccess.Model
{
    public class CoffeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop()
            {
                Location = "Frankfurt",
                BeansInStockInKg = 107,
                PaperCupInStock = 350
            };
            yield return new CoffeeShop()
            {
                Location = "Freiburg",
                BeansInStockInKg = 23,
                PaperCupInStock = 140
            };
            yield return new CoffeeShop()
            {
                Location = "Munich",
                BeansInStockInKg = 56,
                PaperCupInStock = 235
            };
        }
    }
}
