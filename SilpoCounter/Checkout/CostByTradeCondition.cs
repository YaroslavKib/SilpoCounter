using System.Linq;
using System.Collections.Generic;

namespace SilpoCounter.Checkout
{
    public class CostByTradeCondition : ICondition
    {
        public int ConditionResult { get; private set; }

        public void CountCondition(Check check)
            => throw new System.NotImplementedException();
    }
}
