using System;

namespace SilpoCounter.Checkout
{
    public class FactorByCategoryOffer : Offer
    {
        public override DateTime ExpiresAt { get; set; }

        public Category Category { get; private set; }
        public int Factor { get; private set; }

        public FactorByCategoryOffer(Category category, int factor, DateTime expiresAt = default(DateTime))
        {
            Category = category;
            Factor = factor;
            ExpiresAt = expiresAt;
        }
        
        public override void Apply(Check check)
        {
            var points = check.GetCostByCategory(this.Category);
            check.AddPoints(points * (this.Factor - 1));
        }
    }
}
