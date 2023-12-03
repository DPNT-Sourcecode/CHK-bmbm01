namespace BeFaster.App.Solutions.CHK
{
    public abstract class SpecialOffer
    {
        public char Item { get; set; }

        public int Quantity { get; set; }

        public abstract void ApplyOffer(Basket basket);
    }
}
