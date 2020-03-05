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
            => check.AddProduct(product);

        public Check CloseCheck()
        {
            return check;
        }
    }
}