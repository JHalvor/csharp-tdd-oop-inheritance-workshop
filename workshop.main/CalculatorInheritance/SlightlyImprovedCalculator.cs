using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.CalculatorInheritance
{
    public class SlightlyImprovedCalculator : Calculator
    {
        public override int Add(int a, int b)
        {          
            return b + a;
        }
        public override int Multiply(int a, int b)
        {
            return b * a;   
        }

    }
}
