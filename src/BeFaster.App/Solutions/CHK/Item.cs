using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public class Item
    {
        public char Name { get; set; }

        public int Price { get; set; }

        public List<SpecialOffer> SpecialOffers { get; set; }
    }
}
