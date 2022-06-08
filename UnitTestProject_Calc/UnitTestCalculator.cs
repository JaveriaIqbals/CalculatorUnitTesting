using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorTest;

namespace UnitTestProject_Calc
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        public void AddTest()
        {
            BasicCalculator calculator = new BasicCalculator();
            // Check Equality : Add 3+2
            Assert.AreEqual(5, calculator.Add(2, 3)); // here 5 is expected value
            Assert.AreEqual(50, calculator.Add(20, 30));
            Assert.AreEqual(-5, calculator.Add(-2, -3)); 
        }
        [TestMethod]
        public void SubTest()
        {
            BasicCalculator calculator = new BasicCalculator();
            Assert.AreEqual(50, calculator.Sub(100, 50));
            Assert.AreEqual(-60, calculator.Sub(-10, 50));
        }
        
        [TestMethod]
        public void PowerTest()
        {
            BasicCalculator calculator = new BasicCalculator();
            Assert.AreEqual(100, calculator.Power(10, 2));
            Assert.AreEqual(8, calculator.Power(2, 3));
        }

    }
}
