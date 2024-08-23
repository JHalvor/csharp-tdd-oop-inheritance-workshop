using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.CalculatorComposition
{
    internal class MultiplyEngine : ICalculation
    {
        public int Calculate(int a, int b)
        {
            return a * b;
        }
    }
}
