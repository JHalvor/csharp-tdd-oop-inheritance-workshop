using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.main.CalculatorComposition
{
    public class AddEngine : ICalculation
    {
        public int Calculate(int a, int b)
        {
            return a + b;
        }

       
    }
}
