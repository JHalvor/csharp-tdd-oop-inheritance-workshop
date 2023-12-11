// See https://aka.ms/new-console-template for more information
using workshop.main;

List<Product> products = new List<Product>();




Guitar g1 = new Guitar("Gibson SG") { Discount = 10, Price = 1000.00M };
Guitar g2 = new Guitar("Fender") { Discount = 25, Price = 1000.00M };

Drums d1 = new Drums("Mapex") { Discount = 300, Price = 1000.00M };

products.Add(g1);
products.Add(g2);
products.Add(d1);

products.ForEach(p =>
{
    Console.WriteLine($"{p.Name} £{p.CalculateDiscount()}");
});
