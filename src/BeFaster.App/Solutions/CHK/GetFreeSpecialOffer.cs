namespace BeFaster.App.Solutions.CHK
{
    public class GetFreeSpecialOffer : SpecialOffer
    {
        public char FreeItem { get; set; }

        public int FreeItemQuantity { get; set; }

        public int FreeItemPrice { get; set; }

        public override void ApplyOffer(Basket basket)
        {
            if (basket.ItemsCount.ContainsKey(Item))
            {
                var numberOfItems = basket.ItemsCount[Item];
                var numberOfSpecialOffers = numberOfItems / Quantity;

                basket.ItemsCount[FreeItem] -= numberOfSpecialOffers * FreeItemQuantity;
                basket.Price -= FreeItemPrice * numberOfSpecialOffers;
            }
        }
    }
}



