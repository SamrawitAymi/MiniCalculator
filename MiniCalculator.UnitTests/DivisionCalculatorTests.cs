using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCalculator.UnitTests
{
    [TestClass()]
    public class DivisionCalculatorTests
    {
        [TestMethod()]
        public void DivideTwoNumbers_ReturnsResult_Pass()
        {
            //Arrange
            int a = 8;
            int b = 4;

            //Act
            double expectedResult = 2;
            Calculator.Divide(a, b);


            //Assert
            Assert.AreEqual(expectedResult, Calculator.DivisionResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
               expectedResult, a, b, Calculator.DivisionResult);
        }

        [TestMethod()]
        public void DivideTwoNumbers_NotReturnsResult_Fail()
        {
            //Arrange
            int a = 8;
            int b = 4;

            //Act
            double expectedResult = 1;
            Calculator.Divide(a, b);

            //Assert
            Assert.AreNotEqual(expectedResult, Calculator.DivisionResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
                expectedResult, a, b, Calculator.DivisionResult);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void DenominatorCanNotBeZero()
        {
            int a = 10, b = 0;
            Calculator.Divide(a, b);

        }

    }
}