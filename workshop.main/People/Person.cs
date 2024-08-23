using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.People
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello, I'm {Name} and I am {Age}.");
        }
       
        public virtual void About()
        {
            Console.WriteLine($"I am a person named {Name}, and I am {Age} years old.");
        }
    }
}
