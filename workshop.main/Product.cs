namespace workshop.main
{
    public abstract class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public virtual decimal CalculateDiscount()
        {
            return this.Price - ((this.Discount / 100) * this.Price);
        }

    }
}
