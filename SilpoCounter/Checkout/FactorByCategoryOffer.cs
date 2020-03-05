namespace SilpoCounter.Checkout
{
    public class FactorByCategoryOffer : Offer
    {
        public Category Category;
        public int Factor;

        public FactorByCategoryOffer(Category category, int factor)
        {
            Category = category;
            Factor = factor;
        }
        
        public override void Apply(Check check)
        {

        }
    }
}
