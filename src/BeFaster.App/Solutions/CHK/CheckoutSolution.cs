using BeFaster.Runner.Exceptions;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<string, Item> Prices = new Dictionary<string, Item>()
        {
            { "A", new Item { Name = "A", Price = 50, SpecialOfferQuantity = 3, SpecialOfferPrice = 130 } },
            { "B", new Item { Name = "A", Price = 30, SpecialOfferQuantity = 2, SpecialOfferPrice = 45 } },
            { "C", new Item { Name = "A", Price = 20 } },
            { "D", new Item { Name = "A", Price = 15 } },
        };

        public static int ComputePrice(string skus)
        {
            throw new SolutionNotImplementedException();
        }
    }
}
