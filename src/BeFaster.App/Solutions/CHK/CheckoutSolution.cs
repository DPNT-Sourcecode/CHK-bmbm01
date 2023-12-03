using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<char, Item> Items = new Dictionary<char, Item>()
        {
            { 'A', new Item { Name = 'A', Price = 50, SpecialOffers = new List<SpecialOffer>() { new DiscountSpecialOffer { Item = 'A', Quantity = 5, Value = 200 }, new DiscountSpecialOffer { Item = 'A', Quantity = 3, Value = 130 } } } },
            { 'B', new Item { Name = 'B', Price = 30, SpecialOffers = new List<SpecialOffer>() { new DiscountSpecialOffer { Item = 'B', Quantity = 2, Value = 45 } } } },
            { 'C', new Item { Name = 'C', Price = 20, SpecialOffers = new List<SpecialOffer>() } },
            { 'D', new Item { Name = 'D', Price = 15, SpecialOffers = new List<SpecialOffer>() } },
            { 'E', new Item { Name = 'E', Price = 40, SpecialOffers = new List<SpecialOffer>() { new GetFreeSpecialOffer { Item = 'E', Quantity = 2, FreeItem = 'B', FreeItemQuantity = 2, FreeItemPrice = 30 } } } }
        };

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
            var keys = new List<char>(basket.ItemsCount.Keys);

            foreach (var key in keys)
            {
                var item = Items[key];

                foreach (var specialOffer in item.SpecialOffers)
                {
                    specialOffer.ApplyOffer(basket);
                }
            }
        }

        private static void CalculateRegularPrices(Basket basket)
        {
            foreach (var entry in basket.ItemsCount)
            {
                var item = Items[entry.Key];
                basket.Price += entry.Value * item.Price;
            }
        }
    }
}


