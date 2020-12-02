using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiniCalculator.UnitTests
{
    [TestClass]
    public class SubtractionMiniCalculatorTests
    {
        [TestMethod()]
        public void SubtructTwoNumbers_ReturnsDiffernceResult_Pass()
        {
            //Arrange
            int a = 4;
            int b = 4;

            //Act
            double expectedResult = 0;
            double actualResult = Calculator.Subtract(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
               expectedResult, a, b, actualResult);
        }


        [TestMethod()]
        public void SubtructTwoNumbers_NotReturnsDiffernceResult_Fail()
        {
            //Arrange
            int a = 8;
            int b = 4;

            //Act
            double expectedResult = 5;
            double actualResult = Calculator.Subtract(a, b);

            //Assert
            Assert.AreNotEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
               expectedResult, a, b, actualResult);
        }
    }
}
