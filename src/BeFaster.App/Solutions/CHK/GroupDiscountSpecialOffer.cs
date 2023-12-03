using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var remainingItems = totalCount % Quantity;

            if (remainingItems > 0)
            {
                var itemsOrderedByValue = ItemGroup.OrderByDescending(pair => pair.Value).ToList();

                foreach (var item in itemsOrderedByValue)
                {
                    if (itemsFound.ContainsKey(item.Key) && itemsFound[item.Key] <= totalCount)
                    {
                        totalCount -= itemsFound[item.Key];
                        basket.ItemsCount[item.Key] -= item.Value;
                    }
                    else
                    {
                        basket.ItemsCount[item.Key] -= item.Value - remainingItems;
                        break;
                    }
                }
            }

            basket.Price += (totalCount / Quantity) * Price;
        }

    }
}









