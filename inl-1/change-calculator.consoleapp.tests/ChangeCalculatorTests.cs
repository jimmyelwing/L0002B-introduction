using System.Collections.Generic;
using changecalculator.consoleapp;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace change_calculator.consoleapp.tests
{
    [TestClass]
    public class ChangeCalculatorTests
    {
        private ChangeCalculator SUT;

        public ChangeCalculatorTests()
        {
            SUT = new ChangeCalculator();
        }

        [TestMethod]
        public void IfChangeIs100_ReturnA100Bill()
        {
            var change = 100;

            var result = SUT.CalculateChange(change);

            var expected = new List<int>();
            expected.Add(100);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IfChangeIs200_ReturnTwo100Bills()
        {
            var change = 200;

            var result = SUT.CalculateChange(change);

            var expected = new List<int>();
            expected.Add(100);
            expected.Add(100);

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IfChangeIs250_ReturnTwo100BillsAndOne50Bill()
        {
            var change = 250;

            var result = SUT.CalculateChange(change);

            var expected = new List<int>();
            expected.Add(100);
            expected.Add(100);
            expected.Add(50);

            CollectionAssert.AreEqual(expected,result);
        }
        
    }
}
