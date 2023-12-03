namespace BeFaster.App.Solutions.CHK
{
    public abstract class SpecialOffer
    {
        public int Quantity { get; set; }

        public abstract void ApplyOffer(Basket basket);
    }
}


