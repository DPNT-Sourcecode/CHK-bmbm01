﻿using BeFaster.Runner.Exceptions;
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
            var purchasedItems = new Dictionary<char, int>();
            var price = 0;

            foreach (var sku in skus)
            {
                if (Items.ContainsKey(sku))
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
    }
}





