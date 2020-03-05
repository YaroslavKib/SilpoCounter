namespace SilpoCounter.Checkout
{
    public class CheckoutService
    {
        private Check check;

        public void OpenCheck()
        {
            check = new Check();
        }

        public void AddProduct(Product product)
        {
            if (check == null)
                OpenCheck();

            check.AddProduct(product);
        } 

        public Check CloseCheck()
        {
            Check closedCheck = check;
            check = null;

            return closedCheck;
        }

        public void UseOffer(Offer offer)
        {
            offer.Apply(check);

            if (offer is FactorByCategoryOffer)
            {
                var fbOffer = offer as FactorByCategoryOffer;
                var points = check.GetCostByCategory(fbOffer.Category);
                check.AddPoints(points * (fbOffer.Factor - 1));
            }
            else if (offer is AnyGoodsOffer)
            {
                var agOffer = offer as AnyGoodsOffer;
                
                if(agOffer.TotalCost <= check.GetTotalCost())
                    check.AddPoints(agOffer.Points);
            }
        }
    }
}
