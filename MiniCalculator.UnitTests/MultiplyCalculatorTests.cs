using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCalculator.UnitTests
{
    [TestClass()]
    public class MultiplyCalculatorTests
    {
        [TestMethod()]
        public void MultiplyTwoNumbers_ReturnsResult_Pass()
        {
            //Arrange
            int a = 8;
            int b = 4;

            //Act
            double expectedResult = 32;
            double actualResult = Calculator.Multiply(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
               expectedResult, a, b, actualResult);
        }

        [TestMethod()]
        public void MultiplyTwoNumbers_NotReturnsResult_Fail()
        {
            //Arrange
            int a = 8;
            int b = 4;

            //Act
            double expectedResult = 13;
            double actualResult = Calculator.Multiply(a, b);

            //Assert
            Assert.AreNotEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
                expectedResult, a, b, actualResult);
        }

    }
}
