using System;

namespace SilpoCounter.Checkout
{
    public abstract class Offer
    {
        public DateTime ExpiresAt { get; private set; }
        public ICondition Condition { get; internal set; }

        public bool IsExpired => 
            ExpiresAt != default(DateTime)
            && DateTime.Now > ExpiresAt;

        public void Use(Check check)
        {
            if (!IsExpired) 
            {
                Condition.CountCondition(check);
                Apply(check);
            }
        }

        public abstract void Apply(Check check);
    }
}
