namespace BeFaster.App.Solutions.CHK
{
    public class GetFreeConditionalSpecialOffer : GetFreeSpecialOffer
    {
        public int MinimumQuantity { get; set; }

        public override void ApplyOffer(Basket basket)
        {
            if (basket.ItemsCount.ContainsKey(Item) && basket.ItemsCount[Item] >= MinimumQuantity)
            {
                base.ApplyOffer(basket);
            }
        }
    }
}
