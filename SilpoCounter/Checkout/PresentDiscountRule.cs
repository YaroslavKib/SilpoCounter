namespace SilpoCounter.Checkout
{
    public class PresentDiscountRule : IDiscountRule
    {
        public ICondition Condition { get; private set; }

        public object Present { get; private set; }

        public Discount CalcDiscount(Check check)
        {
            var discount = new Discount(); // TODO !!!!!
            return discount;
        }
    }
}
