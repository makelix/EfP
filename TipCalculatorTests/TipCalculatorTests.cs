using TipCalculatorNS;

namespace TipCalculatorTestsNS
{
    [TestClass]
    public class TipCalculatorTests
    {
        private const decimal Delta = 0.001M;

        [TestMethod]
        public void ConstructorWithoutParameters_InitsCorrectly()
        {
            TipCalculator tipCalculator = new();
            Assert.AreEqual(0.0M, tipCalculator.BillAmount, Delta);
            Assert.AreEqual(0.0M, tipCalculator.TipRate, Delta);
        }

        [TestMethod]
        public void ConstructorWithParameters_InitsCorrectly()
        {
            TipCalculator tipCalculator = new(100, 5);
            Assert.AreEqual(100.0M, tipCalculator.BillAmount, Delta);
            Assert.AreEqual(5.0M, tipCalculator.TipRate, Delta);
        }

        [TestMethod]
        public void ConstructorWithNegativeValues_ThrowsException()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TipCalculator(-0.1M, 2.2M));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new TipCalculator(3.3M, -0.01M));
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
            Assert.AreEqual(0.0M, tipCalculator.Tip, Delta);

            TipCalculator tipCalculator2 = new(5.0M, 10.0M);
            Assert.AreEqual(0.5M, tipCalculator2.Tip, Delta);
        }

        [TestMethod]
        public void TotalCalculatedCorrectly()
        {
            TipCalculator tipCalculator = new();
            Assert.AreEqual(0.0M, tipCalculator.Total, Delta);

            TipCalculator tipCalculator2 = new(5.0M, 10.0M);
            Assert.AreEqual(5.5M, tipCalculator2.Total, Delta);
        }

        [TestMethod]
        public void RoundUp()
        {
            TipCalculator tipCalculator = new(11.25M, 15);
            Assert.AreEqual("$1.69", tipCalculator.TipAsString);
            Assert.AreEqual("$12.94", tipCalculator.TotalAsString);
        }
    }
}