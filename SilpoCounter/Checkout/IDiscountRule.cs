namespace SilpoCounter.Checkout
{
    public interface IDiscountRule
    {
        ICondition Condition { get; }
        
        Discount CalcDiscount(Check check);
    }
}
