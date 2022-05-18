using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class FibFormula : FindFib
    {
        public int calculate_fib(int k)
        {
            double formula = (1 + Math.Sqrt(5) / 2);
            return (int)Math.Round(Math.Pow(formula, k) / Math.Sqrt(5));
        }
    }
}
