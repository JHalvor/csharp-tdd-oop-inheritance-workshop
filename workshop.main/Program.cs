// See https://aka.ms/new-console-template for more information
using workshop.main.MusicShop;
using workshop.main.People;


List<Product> products = new List<Product>();

Guitar g1 = new Guitar("Gibson SG") { Discount = 10, Price = 1000.00 };
Guitar g2 = new Guitar("Fender Strat") { Discount = 25, Price = 1000.00 };
Drums d1 = new Drums("Mapex Drums") { Discount = 300, Price = 1000.00 };

products.Add(g1);
products.Add(g2);
products.Add(d1);

products.ForEach(p =>
{
    Console.WriteLine($"{p.Name} £{p.CalculateDiscount()}");
});

//////////////////////////////////////

Student student = new Student{Name = "Nigel",Age = 49,School = "Boolean"};
Teacher teacher = new Teacher { Name = "Dave",Age = 21,Subject = "Java"};

student.Introduce();
student.About(); 
student.Study();

teacher.Introduce();
teacher.About(); 
teacher.Teach();




