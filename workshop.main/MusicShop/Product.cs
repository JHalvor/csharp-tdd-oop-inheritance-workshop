namespace workshop.main.MusicShop
{
    public abstract class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public virtual double CalculateDiscount()
        {
            return Price - Discount / 100 * Price;
        }

    }
}
