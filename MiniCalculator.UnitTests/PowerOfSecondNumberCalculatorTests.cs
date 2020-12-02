using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCalculator.UnitTests
{
    [TestClass()]
    public class PowerOfSecondNumberCalculatorTests
    {
        [TestMethod()]
        public void TwoThePowerOfTwo_ReturnsFour_Pass()
        {
            //Arrange
            int a = 2;
            int b = 2;

            //Act
            double expectedResult = 4;
            double actualResult = Calculator.PowOfSecondNumber2(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
               expectedResult, a, b, actualResult);
        }

        [TestMethod()]
        public void TwoThePowerOfTwoReturnsFourNotSix_Fail()
        {
            //Arrange
            int a = 2;
            int b = 2;

            //Act
            double expectedResult = 6;
            double actualResult = Calculator.PowOfSecondNumber2(a, b);

            //Assert
            Assert.AreNotEqual(expectedResult, actualResult);
        }

    }
}