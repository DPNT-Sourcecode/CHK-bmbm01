using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, int> Items = GetItems();

        private static readonly List<SpecialOffer> SpecialOffers = ;

        public static int ComputePrice(string skus)
        {
            var basket = new Basket();

            if(!FillBasket(basket, skus))
            {
                return -1;
            }

            ApplyOffers(basket);

            CalculateRegularPrices(basket);

            return basket.Price;
        }

        private static bool FillBasket(Basket basket, string skus)
        {
            foreach (var sku in skus)
            {
                if (!Items.ContainsKey(sku))
                {
                    return false;
                }

                if (basket.ItemsCount.ContainsKey(sku))
                {
                    basket.ItemsCount[sku] += 1;
                }
                else
                {
                    basket.ItemsCount.Add(sku, 1);
                }
            }

            return true;
        }

        private static void ApplyOffers(Basket basket)
        {
            foreach (var specialOffer in SpecialOffers)
            {
                specialOffer.ApplyOffer(basket);
            }
        }

        private static void CalculateRegularPrices(Basket basket)
        {
            foreach (var entry in basket.ItemsCount)
            {
                var itemValue = Items[entry.Key];
                basket.Price += entry.Value * itemValue;
            }
        }

        private static Dictionary<char, int> GetItems() => new Dictionary<char, int>()
        {
            { 'A', 50 },
            { 'B', 30 },
            { 'C', 20 },
            { 'D', 15 },
            { 'E', 40 },
            { 'F', 10 },
            { 'G', 10 },
            { 'H', 10 },
            { 'I', 10 },
            { 'J', 10 },
            { 'K', 10 },
            { 'L', 10 },
            { 'M', 10 },
            { 'N', 10 },
            { 'O', 10 },
            { 'P', 10 },
            { 'Q', 10 },
            { 'R', 10 },
            { 'S', 10 },
            { 'T', 10 },
            { 'U', 10 },
            { 'V', 10 },
            { 'W', 10 },
            { 'X', 10 },
            { 'Y', 10 },
            { 'Z', 10 },
        };

        private static List<SpecialOffer> GetSpecialOffers() => new List<SpecialOffer>()
        {
            new GetFreeSpecialOffer { Item = 'E', Quantity = 2, FreeItem = 'B', FreeItemQuantity = 1 },
            new GetFreeConditionalSpecialOffer { Item = 'F', Quantity = 3, FreeItem = 'F', FreeItemQuantity = 1, MinimumQuantity = 3 },
            new DiscountSpecialOffer { Item = 'A', Quantity = 5, Value = 200 },
            new DiscountSpecialOffer { Item = 'A', Quantity = 3, Value = 130 },
            new DiscountSpecialOffer { Item = 'B', Quantity = 2, Value = 45 }
        };
    }
}

