using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    public class GroupDiscountSpecialOffer : SpecialOffer
    {
        public HashSet<char> ItemGroup { get; set; } = new HashSet<char>();

        public int Price { get; set; }

        public override void ApplyOffer(Basket basket)
        {
            var itemsFound = new Dictionary<char, int>();
            var totalCount = 0;

            foreach (var item in ItemGroup)
            {
                if (basket.ItemsCount.ContainsKey(item))
                {
                    var count = basket.ItemsCount[item];
                    itemsFound.Add(item, count);
                    totalCount += count;
                }
            }

            if (totalCount % Quantity == 0)
            {
                // Remove all items from basket
                // Add multiplier price
            }
            else
            {

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




