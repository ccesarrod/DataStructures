using Algorithms;
using NUnit.Framework;

namespace TestData
{
    [TestFixture]
   public  class TestmathAlgorithms
    {
        [Test]
        public void test_power()
        {
            var result = MatCalculator.Power(2, 4);

            Assert.AreEqual(16, result);
        }

        [Test]
        public void test_factorial()
        {
            var result = MatCalculator.Factorial(5);

            Assert.AreEqual(120, result);
        }

        [Test]
        public void test_digit()
        {
            var sumYp = new SumDigitsOfNumber();
            var result = sumYp.SumpUp(156);

            Assert.AreEqual(12, result);
        }

        [Test]
        public void test_digit_deci()
        {
            var sumYp = new SumDigitsOfNumber();
            var result = sumYp.SumpUpMath(156);

            Assert.AreEqual(12, result);
        }

        [Test]
        public void test_digit_deci_recursive()
        {
            var sumYp = new SumDigitsOfNumber();
            var result = sumYp.SumpUpRecursive(156);

            Assert.AreEqual(12, result);
        }
    }
}
