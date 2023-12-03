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
                var leastValuableItems = ItemGroup.OrderBy(pair => pair.Value).ToList();

                foreach (var leastValueableItem in leastValuableItems)
                {
                    if (itemsFound.ContainsKey(leastValueableItem.Key) && leastValueableItem.Value <= remainingItems)
                    {
                        remainingItems -= leastValueableItem.Value;
                        itemsFound[leastValueableItem.Key] -= leastValueableItem.Value;
                    }

                    if (remainingItems == 0)
                    {
                        break;
                    }
                }
            }

            foreach (var entry in itemsFound)
            {
                basket.ItemsCount[entry.Key] -= entry.Value;
            }

            basket.Price += (totalCount / Quantity) * Price;
        }

    }
}






