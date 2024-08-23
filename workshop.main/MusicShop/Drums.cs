namespace workshop.main.MusicShop
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
        public override double CalculateDiscount()
        {
            return Price - Discount;
        }
    }
}
