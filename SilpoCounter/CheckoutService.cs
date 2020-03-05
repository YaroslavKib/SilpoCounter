using System.Collections.Generic;

namespace SilpoCounter
{
    public class CheckoutService
    {
        private Check check;

        public void OpenCheck()
        {
            check = new Check();
            check.Products = new List<Product>();
            check.TotalCost = 0;
        }

        public void AddProduct(Product product)
            => check.Products.Add(product);

        public Check CloseCheck()
        {
            foreach(var product in check.Products)
                check.TotalCost += product.Price;

            return check;
        }
    }
}