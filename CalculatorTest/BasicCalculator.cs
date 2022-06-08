using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    public class BasicCalculator
    {

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Sub(double a, double b)
        {
           return a - b;
        }
        public double Power(double num, double exp)
        {
            return Math.Pow(num, exp); // num^exp
        }
    }
}
