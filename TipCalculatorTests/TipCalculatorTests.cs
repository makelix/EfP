using TipCalculatorNS;

namespace TipCalculatorTestsNS
{
    [TestClass]
    public class TipCalculatorTests
    {
        private const double Delta = 0.001;

        [TestMethod]
        public void ConstructorWithoutParameters_InitsCorrectly()
        {
            TipCalculator tipCalculator = new();
            Assert.AreEqual(0.0, tipCalculator.BillAmount, Delta);
            Assert.AreEqual(0.0, tipCalculator.TipRate, Delta);
        }

        [TestMethod]
        public void ConstructorWithParameters_InitsCorrectly()
        {
            TipCalculator tipCalculator = new(100, 5);
            Assert.AreEqual(100.0, tipCalculator.BillAmount, Delta);
            Assert.AreEqual(5.0, tipCalculator.TipRate, Delta);
        }

        [TestMethod]
        public void ConstructorWithNegativeValues_ThrowsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TipCalculator(-0.1, 2.2));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TipCalculator(3.3, -0.01));
        }

        [TestMethod]
        public void StringGetters_FormatCorrectly()
        {
            TipCalculator tipCalculator = new();
            Assert.AreEqual("$0.00", tipCalculator.TipAsString);
            Assert.AreEqual("$0.00", tipCalculator.TotalAsString);
        }

        [TestMethod]
        public void TipCalculatedCorrectly()
        {
            TipCalculator tipCalculator = new();
            Assert.AreEqual(0.0, tipCalculator.Tip, Delta);

            TipCalculator tipCalculator2 = new(5.0, 10.0);
            Assert.AreEqual(0.5, tipCalculator2.Tip, Delta);
        }

        [TestMethod]
        public void TotalCalculatedCorrectly()
        {
            TipCalculator tipCalculator = new();
            Assert.AreEqual(0.0, tipCalculator.Total, Delta);

            TipCalculator tipCalculator2 = new(5.0, 10.0);
            Assert.AreEqual(5.5, tipCalculator2.Total, Delta);
        }
    }
}