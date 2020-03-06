namespace SilpoCounter.Checkout
{
    public class FlatReward : IReward
    {
        public int Points { get; private set; }

        public ICondition Condition { get; private set; }

        public int CalcPoints(Check check)
        { 
            return Condition.ConditionResult + Points; // TODO: check if this is correct
        }

        public FlatReward(int points, ICondition condition)
        {
            Points = points;
            Condition = condition;
        }
    }
}
