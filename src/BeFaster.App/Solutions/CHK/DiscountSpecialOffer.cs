using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    public class DiscountSpecialOffer : SpecialOffer
    {
        public int Value { get; set; }

        public override void ApplyOffer(Basket basket)
        {
            var numberOfItems = basket.ItemsCount[Item];
            throw new NotImplementedException();
        }
    }
}



