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

            if (remainingItems == 0)
            {
                // Remove all items from basket
                // Add multiplier price
            }
            else
            {
                var leastValuableItems = ItemGroup.OrderBy(pair => pair.Value);
                while(remainingItems > 0)
                {

                }
            }
        }

        private void RemoveItems(Basket basket)
        {
            var foundItems = new Dictionary<char, int>();

            for (var item in ItemGroup)
            {
                if (basket.ItemsCount[item])
                {
                                                                                                                                                                                                                                                                                                                                                                                                                        
                }
            }
        }

        private bool HasEnoughItems()
        {
            
        }
    }
}

