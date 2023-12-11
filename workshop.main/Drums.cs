namespace workshop.main
{
    public class Drums : Product
    {
        public Drums(string name) : base(name)
        {

        }
        /// <summary>
        /// drums discount is calculated directly
        /// </summary>
        /// <returns></returns>
        public override decimal CalculateDiscount()
        {
            return this.Price - this.Discount;
        }
    }
}
