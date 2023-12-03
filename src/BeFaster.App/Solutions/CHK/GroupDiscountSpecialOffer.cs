using System.Collections.Generic;
using System.Linq;

namespace BeFaster.App.Solutions.CHK
{
    public class GroupDiscountSpecialOffer : SpecialOffer
    {
        public Dictionary<char, int> ItemGroup { get; set; } = new Dictionary<char, int>();

        public int Price { get; set; }

        public override void ApplyOffer(Basket basket)
        {
            var itemsFound = new Dictionary<char, int>();
            var totalCount = 0;

            foreach (var entry in ItemGroup)
            {
                if (basket.ItemsCount.ContainsKey(entry.Key))
                {
                    var count = basket.ItemsCount[entry.Key];
                    itemsFound.Add(entry.Key, count);
                    totalCount += count;
                }
            }

            if (totalCount >= Quantity)
            {
                UpdateBasket(basket, itemsFound, totalCount);
                basket.Price += (totalCount / Quantity) * Price;
            }
        }

        private void UpdateBasket(Basket basket, Dictionary<char, int> itemsFound, int totalCount)
        {
            var remainingItems = totalCount % Quantity;

            if (remainingItems > 0)
            {
                var totalToRemove = totalCount - remainingItems;
                var itemsOrderedByValue = ItemGroup.OrderByDescending(pair => pair.Value).ToList();

                foreach (var item in itemsOrderedByValue)
                {
                    if (itemsFound.ContainsKey(item.Key))
                    {
                        if (itemsFound[item.Key] <= totalToRemove)
                        {
                            totalToRemove -= itemsFound[item.Key];
                            basket.ItemsCount[item.Key] -= itemsFound[item.Key];
                        }
                        else
                        {
                            basket.ItemsCount[item.Key] -= totalToRemove;
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (var item in itemsFound)
                {
                    basket.ItemsCount[item.Key] -= item.Value;
                }
            }
        }
    }
}
