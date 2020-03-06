using System;

namespace SilpoCounter.Checkout
{
    public class DiscountOffer : Offer
    {
        public IDiscountRule Discount { get; private set; }

        public DiscountOffer(IDiscountRule discount, ICondition condition)
        {
            Discount = discount;
            Condition = condition;
        }

        public override void Apply(Check check)
        {
            // FIXME: here we should do some condition job????
            var discount= Discount.CalcDiscount(check);
            // TODO
            // check.AddDiscount(discount);
        }
    }
}
