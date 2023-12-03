namespace BeFaster.App.Solutions.CHK
{
    public class GetFreeSpecialOffer : SpecialOffer
    {
        public char FreeItem { get; set; }

        public int FreeItemQuantity { get; set; }

        public override void ApplyOffer(Basket basket)
        {
            if (basket.ItemsCount.ContainsKey(Item) && basket.ItemsCount.ContainsKey(FreeItem))
            {
                var numberOfItems = basket.ItemsCount[Item];
                var numberOfSpecialOffers = numberOfItems / Quantity;

                basket.ItemsCount[FreeItem] -= numberOfSpecialOffers * FreeItemQuantity;
            }
        }
    }
}
