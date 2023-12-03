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
            for (var item in ItemGroup)
            {
                if (basket.ItemsCount[])
            }
            throw new NotImplementedException();
        }
    }
}

