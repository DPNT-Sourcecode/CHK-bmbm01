using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFaster.App.Solutions.CHK
{
    public class Item
    {
        public char Name { get; set; }

        public int Price { get; set; }

        public List<SpecialOffer> SpecialOffers { get; set; }
    }
}
