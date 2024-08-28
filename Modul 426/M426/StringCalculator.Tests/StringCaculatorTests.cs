namespace StringCalculator.Tests
{
    [TestClass]
    public class StringCaculatorTests
    {
        [TestMethod]
        public void ZeroStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("");

            // Asset
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void OneString()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("7");

            // Asset
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void ZwoStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("1,4");

            // Asset
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ThreeStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("7,8,3");

            // Asset
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void TenStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("1,2,3,4,5,6,7,8,9,10");

            // Asset
            Assert.AreEqual(55, result);
        }

        [TestMethod]
        public void BackSlashNStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("1\n2,3");

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void MultipleDelimitersStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add(";\n1;2");

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void NegativeStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act and Assert
            var ex = Assert.ThrowsException<InvalidOperationException>(() => calc.Add("-1,3,-2"));

            // Assert
            Assert.AreEqual("Negatives not allowed: -1, -2", ex.Message);
        }

        [TestMethod]
        public void IgnoreNumberStrings()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            var result = calc.Add("2, 1001");

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalledCount_MethodeAdd()
        {
            // Arrange
            var calc = new StringCalculator();

            // Act
            calc.Add("1,2,3");
            calc.Add("4,5,6");
            calc.Add("4,5,6");

            // Assert
            Assert.AreEqual(3, calc.CalledCount);
        }
    }
}