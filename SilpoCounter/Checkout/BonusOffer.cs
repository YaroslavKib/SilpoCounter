using System;

namespace SilpoCounter.Checkout
{
    public class BonusOffer : Offer
    {
        public IReward Reward { get; private set; }

        public BonusOffer(IReward reward, ICondition condition)
        {
            Reward = reward;
            Condition = condition;
        }

        public override void Apply(Check check)
        {
            var points = Reward.CalcPoints(check);
            check.AddPoints(points); // TODO: check
        }
    }
}
