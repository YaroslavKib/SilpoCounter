namespace SilpoCounter.Checkout
{
    public class FactorReward : IReward
    {
        public int Factor { get; private set; }

        public ICondition Condition { get; private set; }

        public int CalcPoints(Check check)
        { 
            var points = Condition.ConditionResult;
            return points * (this.Factor - 1);
        }

        public FactorReward(int factor, ICondition condition)
        {
            Factor = factor;
            Condition = condition;
        }
    }
}
