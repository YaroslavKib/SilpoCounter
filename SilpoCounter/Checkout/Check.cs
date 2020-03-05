using System.Collections.Generic;
using System.Linq;

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

        public int GetCostByCategory(Category category)
            => Products
            .Where(p => p.Category == category)
            .Select(p => p.Price)
            .Aggregate((a, b) => a + b);

        public void AddProduct(Product product)
            => Products.Add(product);

        public int GetTotalPoints()
            => GetTotalCost() + points;
    }
}
