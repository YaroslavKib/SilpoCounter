namespace SilpoCounter.Checkout
{
    public class FactorByCategoryOffer : Offer
    {
        public Category Category { get; private set; }
        public int Factor { get; private set; }

        public FactorByCategoryOffer(Category category, int factor)
        {
            Category = category;
            Factor = factor;
        }
        
        public override void Apply(Check check)
        {
            var points = check.GetCostByCategory(this.Category);
            check.AddPoints(points * (this.Factor - 1));
        }
    }
}
