namespace SilpoCounter.Checkout
{
    public class AnyGoodsOffer : Offer
    {
        public int TotalCost;
        public int Points;

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
