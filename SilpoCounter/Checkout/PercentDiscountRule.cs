namespace SilpoCounter.Checkout
{
    public class PercentDiscountRule : IDiscountRule
    {
        public ICondition Condition { get; private set; }

        public int Percent { get; private set; }

        public Discount CalcDiscount(Check check)
        {
            var discount = new Discount(); // TODO !!!!!
            return discount;
        }
    }
}
