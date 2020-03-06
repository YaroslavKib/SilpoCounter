namespace SilpoCounter.Checkout
{
    public interface IReward
    {
        ICondition Condition { get; }
        
        int CalcPoints(Check check);
    }
}
