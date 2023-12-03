using BeFaster.Runner.Exceptions;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, Item> Prices = new Dictionary<char, Item>()
        {
            { 'A', new Item { Name = 'A', Price = 50, SpecialOfferQuantity = 3, SpecialOfferPrice = 130 } },
            { 'B', new Item { Name = 'B', Price = 30, SpecialOfferQuantity = 2, SpecialOfferPrice = 45 } },
            { 'C', new Item { Name = 'C', Price = 20 } },
            { 'D', new Item { Name = 'D', Price = 15 } },
        };

        public static int ComputePrice(string skus)
        {
            var items = new Dictionary<char, int>();
            var price = 0;

            foreach (var sku in skus)
            {
                if (items.ContainsKey(sku))
                {
                    items[sku] += 1;
                }
                else
                {
                    items.Add(sku, 1);
                }
            }


            throw new SolutionNotImplementedException();
        }
    }
}

