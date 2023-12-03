using BeFaster.Runner.Exceptions;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, Item> Items = new Dictionary<char, Item>()
        {
            { 'A', new Item { Name = 'A', Price = 50, SpecialOfferQuantity = 3, SpecialOfferPrice = 130 } },
            { 'B', new Item { Name = 'B', Price = 30, SpecialOfferQuantity = 2, SpecialOfferPrice = 45 } },
            { 'C', new Item { Name = 'C', Price = 20 } },
            { 'D', new Item { Name = 'D', Price = 15 } },
        };

        public static int ComputePrice(string skus)
        {
            var price = 0;
            var purchasedItems = GetPurchsedItemsCount(skus);

            foreach(var entry in purchasedItems)
            {
                var item = Items[entry.Key];
                if (item.SpecialOfferQuantity > 0)
                {
                    var specialOfferCount = entry.Value % item.SpecialOfferQuantity;
                }
                else
                {
                    price += entry.Value * item.Price;
                }
            }

            return price;
        }

        private static Dictionary<char, int> GetPurchsedItemsCount(string skus)
        {
            var purchasedItems = new Dictionary<char, int>();

            foreach (var sku in skus)
            {
                if (purchasedItems.ContainsKey(sku))
                {
                    purchasedItems[sku] += 1;
                }
                else
                {
                    purchasedItems.Add(sku, 1);
                }
            }

            return purchasedItems;
        }
    }
}



