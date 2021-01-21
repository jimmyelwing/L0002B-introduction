using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using changecalculator.consoleapp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace change_calculator.consoleapp.tests
{
    [TestClass]
    public class InputVerifierTests
    {
        private InputVerifier SUT;

        public InputVerifierTests()
        {
            SUT = new InputVerifier();
        }

        [TestMethod]
        public void IfUserAddsStringAsPrice_ReturnFalse()
        {
            var input = "abc";

            var result = SUT.VerifyPrice(input);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IfUserAddsANumberInStringAsPrice_ReturnTrue()
        {
            var input = "123";

            var result = SUT.VerifyPrice(input);

            Assert.IsTrue(result);
        }

    }
}
