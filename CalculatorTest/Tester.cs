using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
    internal class Tester
    {
        public static void Main(string [] args)
        {
            BasicCalculator calculator = new BasicCalculator();
            Console.WriteLine(calculator.Sub(20, 10));
            Console.WriteLine(calculator.Add(20, 20));
        }
    }
}
