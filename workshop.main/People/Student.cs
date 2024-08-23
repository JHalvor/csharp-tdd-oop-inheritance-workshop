using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.People
{
    public class Student : Person
    {
        public string School { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying at {School}.");
        }


        public override void About()
        {
            Console.WriteLine($"I am a student named {Name}, and I study at {School}.");
        }
    }
}
