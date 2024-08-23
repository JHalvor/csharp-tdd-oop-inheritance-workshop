using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.CalculatorInheritance
{
    public abstract class Calculator
    {
        public virtual int Add(int a, int b)
        {
            return a + b;
        }
        public virtual int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
