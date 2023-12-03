using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public class Basket
    {
        public Dictionary<char, int> ItemsCount { get; set; } = new Dictionary<char, int>();

        public int Price { get; set; } = 0;
    }
}


