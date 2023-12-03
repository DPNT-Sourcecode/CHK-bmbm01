using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, int> Items = GetItems();
        private static readonly List<SpecialOffer> SpecialOffers = GetSpecialOffers();

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
            { 'G', 20 },
            { 'H', 10 },
            { 'I', 35 },
            { 'J', 60 },
            { 'K', 70 },
            { 'L', 90 },
            { 'M', 15 },
            { 'N', 40 },
            { 'O', 10 },
            { 'P', 50 },
            { 'Q', 30 },
            { 'R', 50 },
            { 'S', 20 },
            { 'T', 20 },
            { 'U', 40 },
            { 'V', 50 },
            { 'W', 20 },
            { 'X', 17 },
            { 'Y', 20 },
            { 'Z', 21 },
        };

        private static List<SpecialOffer> GetSpecialOffers() => new List<SpecialOffer>()
        {
            new GroupDiscountSpecialOffer { ItemGroup = new HashSet<char>() { 'S', 'T', 'X', 'Y', 'Z' }, Quantity = 3, Price = 45 },
            new GetFreeSpecialOffer { Item = 'E', Quantity = 2, FreeItem = 'B', FreeItemQuantity = 1 },
            new GetFreeSpecialOffer { Item = 'N', Quantity = 3, FreeItem = 'M', FreeItemQuantity = 1 },
            new GetFreeSpecialOffer { Item = 'R', Quantity = 3, FreeItem = 'Q', FreeItemQuantity = 1 },
            new GetFreeConditionalSpecialOffer { Item = 'U', Quantity = 3, FreeItem = 'U', FreeItemQuantity = 1, MinimumQuantity = 4 },
            new GetFreeConditionalSpecialOffer { Item = 'F', Quantity = 3, FreeItem = 'F', FreeItemQuantity = 1, MinimumQuantity = 3 },
            new DiscountSpecialOffer { Item = 'A', Quantity = 5, Value = 200 },
            new DiscountSpecialOffer { Item = 'A', Quantity = 3, Value = 130 },
            new DiscountSpecialOffer { Item = 'B', Quantity = 2, Value = 45 },
            new DiscountSpecialOffer { Item = 'H', Quantity = 10, Value = 80 },
            new DiscountSpecialOffer { Item = 'H', Quantity = 5, Value = 45 },
            new DiscountSpecialOffer { Item = 'K', Quantity = 2, Value = 150 },
            new DiscountSpecialOffer { Item = 'P', Quantity = 5, Value = 200 },
            new DiscountSpecialOffer { Item = 'Q', Quantity = 3, Value = 80 },
            new DiscountSpecialOffer { Item = 'V', Quantity = 3, Value = 130 },
            new DiscountSpecialOffer { Item = 'V', Quantity = 2, Value = 90 },
        };
    }
}


