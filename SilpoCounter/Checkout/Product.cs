namespace SilpoCounter.Checkout
{
    public class Product
    {
        public int Price { get; private set; }
        public string Name { get; private set; }
        public Category Category { get; private set; }

        public Product(int price, string name, Category category = Category.Unknown)
        {
            Price = price;
            Name = name;
            Category = category;
        }
    }
}
