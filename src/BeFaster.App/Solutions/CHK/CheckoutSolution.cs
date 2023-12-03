using BeFaster.Runner.Exceptions;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, Item> Items = new Dictionary<char, Item>()
        {
            { 'A', new Item { Name = 'A', Price = 50, SpecialOffers = new List<SpecialOffer>() { new DiscountSpecialOffer { Quantity = 5, Value = 200 }, new DiscountSpecialOffer { Quantity = 3, Value = 130 } } } },
            { 'B', new Item { Name = 'B', Price = 30, SpecialOffers = new List<SpecialOffer>() { new DiscountSpecialOffer { Quantity = 2, Value = 45 } } } },
            { 'C', new Item { Name = 'C', Price = 20 } },
            { 'D', new Item { Name = 'D', Price = 15 } },
            { 'E', new Item { Name = 'D', Price = 40, SpecialOffers = new List<SpecialOffer>() { new GetFreeSpecialOffer { Quantity = 2, FreeItem = 'B', FreeItemQuantity = 2 } } } }
        };

        public static int ComputePrice(string skus)
        {
            var basket = new Basket();

            if(!FillBasket(basket, skus))
            {
                return -1;
            }

            ApplyOffers(basket);

            foreach (var sku in skus)
            {
                if (!Items.ContainsKey(sku))
                {
                    return -1;
                }

                if (purchasedItems.ContainsKey(sku))
                {
                    purchasedItems[sku] += 1;
                }
                else
                {
                    purchasedItems.Add(sku, 1);
                }
            }

            foreach(var entry in purchasedItems)
            {
                var item = Items[entry.Key];
                if (item.SpecialOfferQuantity > 0)
                {
                    var regularPriceItems = entry.Value % item.SpecialOfferQuantity;
                    var specialOfferPrice = (entry.Value - regularPriceItems) / item.SpecialOfferQuantity;

                    price += (regularPriceItems * item.Price) + (specialOfferPrice * item.SpecialOfferPrice);
                }
                else
                {
                    price += entry.Value * item.Price;
                }
            }

            return price;
        }

        private static bool FillBasket(Basket basked, string skus)
        {
            foreach (var sku in skus)
            {
                if (!Items.ContainsKey(sku))
                {
                    return false;
                }

                if (basked.ItemsCount.ContainsKey(sku))
                {
                    basked.ItemsCount[sku] += 1;
                }
                else
                {
                    basked.ItemsCount.Add(sku, 1);
                }
            }

            return true;
        }

        private static void ApplyOffers(Basket basked)
        {
            var basket = new Basket();
        }
    }
}





