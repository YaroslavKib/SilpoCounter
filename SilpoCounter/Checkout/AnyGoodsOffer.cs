using System;

namespace SilpoCounter.Checkout
{
    public class AnyGoodsOffer : Offer
    {
        public override DateTime ExpiresAt { get; set; }

        public int TotalCost { get; private set; }
        public int Points { get; private set; }

        public AnyGoodsOffer(int totalCost, int points, DateTime expiresAt = default(DateTime))
        {
            TotalCost = totalCost;
            Points = points;
            ExpiresAt = expiresAt;
        }

        public override void Apply(Check check)
        {
            if (this.TotalCost <= check.GetTotalCost())
                check.AddPoints(this.Points);
        }
    }
}
