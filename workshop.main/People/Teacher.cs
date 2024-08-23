using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.People
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}.");
        }


        public override void About()
        {
            Console.WriteLine($"I am a teacher named {Name}, and I teach {Subject}.");
        }
    }

}
