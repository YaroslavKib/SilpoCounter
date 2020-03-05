namespace SilpoCounter.Checkout
{
    public class AnyGoodsOffer : Offer
    {
        public int TotalCost { get; private set; }
        public int Points { get; private set; }

        public AnyGoodsOffer(int totalCost, int points)
        {
            TotalCost = totalCost;
            Points = points;
        }

        public override void Apply(Check check)
        {

        }
    }
}
