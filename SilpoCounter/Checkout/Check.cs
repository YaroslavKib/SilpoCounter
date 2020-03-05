using System.Collections.Generic;

namespace SilpoCounter.Checkout
{
    public class Check
    {
        private List<Product> Products = new List<Product>();
        private int points = 0;

        public int GetTotalCost()
        {
            int totalCost = 0;

            foreach (var product in Products)
                totalCost += product.Price;

                return totalCost;
        }

        public void AddPoints(int points)
            => this.points += points;

        public void AddProduct(Product product)
            => Products.Add(product);

        public int GetTotalPoints()
            => GetTotalCost() + points;
    }
}
