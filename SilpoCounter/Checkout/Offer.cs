using System;

namespace SilpoCounter.Checkout
{
    public abstract class Offer
    {
        public abstract DateTime ExpiresAt { get; set; }
        public bool IsExpired => 
            ExpiresAt != default(DateTime)
            && DateTime.Now > ExpiresAt;

        public abstract void Apply(Check check);
    }
}