namespace SilpoCounter.Checkout
{
    public class FactorByCategoryOffer : AnyGoodsOffer
    {
        public Category Category;
        public int Factor;

        public FactorByCategoryOffer(Category category, int factor) : base(0, 0)
        {
            Category = category;
            Factor = factor;
        }
    }
}
