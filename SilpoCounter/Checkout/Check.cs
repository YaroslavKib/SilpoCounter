using System;
using System.Collections.Generic;
using System.Linq;

namespace SilpoCounter.Checkout
{
    public class Check
    {
        private List<Product> Products = new List<Product>();
        private int points = 0;

        // this one should return a copy, not direct reference
        // 'cuz we don't want client to be able to remove Products directly
        public IEnumerable<Product> GetProducts() 
            => Products.AsEnumerable();

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
