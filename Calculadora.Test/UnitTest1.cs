using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumaTest(double num1, double num2, double expectedResult)
        {
            num1 = 5;
            num2 = 6.3;
            expectedResult = num1 + num2;

            Calculadora calculo = new Calculadora();
            double actualResult = calculo.Suma(num1, num2);

            Assert.AreEqual(expectedResult, actualResult, "The expected result was {0} , using a={1} and b={2}, but the actual result was {3}",
               expectedResult, num1, num2, actualResult);

        }
    }
}
