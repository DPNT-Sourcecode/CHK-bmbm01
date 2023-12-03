namespace BeFaster.App.Solutions.CHK
{
    public class DiscountSpecialOffer : SpecialOffer
    {
        public int Value { get; set; }

        public override void ApplyOffer(Basket basket)
        {
            var numberOfItems = basket.ItemsCount[Item];
            var numberOfSpecialOffers = numberOfItems / Quantity;
            var numberOfSpecialOfferItems = numberOfSpecialOffers * Quantity;

            basket.ItemsCount[Item] -= numberOfSpecialOfferItems;
            basket.Price += numberOfSpecialOffers * Value;
        }
    }
}




