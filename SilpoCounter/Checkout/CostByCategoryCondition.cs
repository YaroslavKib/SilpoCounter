using System.Linq;
using System.Collections.Generic;

namespace SilpoCounter.Checkout
{
    public class CostByCategoryCondition : ICondition
    {
        public int ConditionResult { get; private set; }
        public Category Category { get; private set; }

        public void CountCondition(Check check)
        {
            ConditionResult = check.GetProducts()
                .Where(p => p.Category == Category)
                .Select(p => p.Price)
                .Aggregate((a, b) => a + b);
        }

        public CostByCategoryCondition(Category category)
        {
            Category = category;
        }
    }
}
