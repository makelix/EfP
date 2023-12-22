using TipCalculatorNS;

namespace TipCalculatorTestsNS
{
    [TestClass]
    public class TipCalculatorTests
    {
        private const double Delta = 0.001;

        [TestMethod]
        public void ConstructorWithoutParameters()
        {
            TipCalculator tipCalculator = new();
            Assert.AreEqual(0.0, tipCalculator.BillAmount, Delta);
            Assert.AreEqual(0.0, tipCalculator.TipPercentage, Delta);
        }

        [TestMethod]
        public void ConstructorWithParameters()
        {
            TipCalculator tipCalculator = new(100, 5);
            Assert.AreEqual(100.0, tipCalculator.BillAmount, Delta);
            Assert.AreEqual(5.0, tipCalculator.TipPercentage, Delta);
        }

        [TestMethod]
        public void ConstructorWithNegativeValues_ThrowsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TipCalculator(-0.1, 2.2));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TipCalculator(3.3, -0.01));
        }
    }
}