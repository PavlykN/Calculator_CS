using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorEngineTests
    {
        private CalculatorEngine calc;

        [TestInitialize]
        public void Setup()
        {
            calc = new CalculatorEngine();
        }

        [TestMethod()]
        public void SumTest_10and20_30returned()
        {
            // arrange
            double first = 10;
            double second = 20;
            double expected = 30;

            // act      
            double actual = calc.Sum(first, second);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(30, 10, 20)]
        [DataRow(1, 1, 0)]
        [DataRow(0, 0, 0)]
        public void SubstractionTest_Values_ReturnExpected(double first, double second, double expected)
        {
            double actual = calc.Subtraction(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplicationTest_2and5_10returned()
        {
            double first = 2;
            double second = 5;
            double expected = 10;

            double actual = calc.Multiplication(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DivisionTest_10and5_2returned()
        {
            double first = 10;
            double second = 5;
            double expected = 2;

            double actual = calc.Division(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindSqrtTest_121_11returned()
        {
            double val = 121;
            double expected = 11;

            double actual = calc.FindSqrt(val);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FindPowTest_3_toPow2_9expected()
        {
            double first = 3;
            double second = 2;
            double expected = 9;

            double actual = calc.FindPow(first, second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTest_DivideByZero_ThrowsExeption()
        {
            calc.Division(10, 0);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FindSqrt_NegativeNumber_ThrowsExeption()
        {
            calc.FindSqrt(-5);
        }
    }
}