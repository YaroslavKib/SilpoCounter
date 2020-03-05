namespace SilpoCounter.Checkout
{
    public class Product
    {
        public int Price;
        public string Name;
        public Category Category;

        public Product(int price, string name, Category category = Category.Unknown)
        {
            Price = price;
            Name = name;
            Category = category;
        }
    }
}
