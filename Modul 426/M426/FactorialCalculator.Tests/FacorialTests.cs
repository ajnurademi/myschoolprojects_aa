namespace FactorialCalculator.Tests
{
    [TestClass]
    public class FacorialTests
    {
        [TestMethod]
        public void ZeroFactorial()
        {
            // Arrange
            var calc = new FactorialCalculator();

            // Act
            var result = calc.Calculate(0);

            // Asset
            Assert.AreEqual<ulong>(1, result);


        }

        [TestMethod]
        public void TwoFactorial()
        {
            // Arrange
            var calc = new FactorialCalculator();

            // Act
            var result = calc.Calculate(2);

            // Asset
            Assert.AreEqual<ulong>(2, result);


        }

        [TestMethod]
        public void ThreeFactorial()
        {
            // Arrange
            var calc = new FactorialCalculator();

            // Act
            var result = calc.Calculate(3);

            // Asset
            Assert.AreEqual<ulong>(6, result);
        }

        [TestMethod]
        public void TenFactorial()
        {
            // Arrange
            var calc = new FactorialCalculator();

            // Act
            var result = calc.Calculate(10);

            // Asset
            Assert.AreEqual<ulong>(3628800, result);
        }
    }
}