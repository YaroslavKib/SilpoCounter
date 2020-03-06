using System;
using System.Collections.Generic;

namespace SilpoCounter.Checkout
{
    public interface ICondition
    {
        int ConditionResult { get; }

        void CountCondition(Check check);
    }
}
