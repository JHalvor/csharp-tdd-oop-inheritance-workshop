using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.CalculatorComposition
{
    public class Calculator
    {
        public int Calculate(ICalculation calculation, int a, int b)
        {
            return calculation.Calculate(a, b);
        }
    }
}
