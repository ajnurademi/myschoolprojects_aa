namespace NumberConverterTest
{

    using NumberConverter;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class converter
    {
        [TestMethod]
        public void RoundUpTest()
        {
            // Arrange
            float valueToRoundUp = 12.3f;
            int expectedValue = 12;
            NumberConverter nc = new NumberConverter();

            // Act
            int actualValue = nc.RoundUp(valueToRoundUp);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void RoundDownTest()
        {
            // Arrange
            float valueToRoundDown = 18;
            int expectedValue = 18;
            NumberConverter nc = new NumberConverter();

            // Act
            int actualValue = nc.RoundDown(valueToRoundDown);

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void RoundDownTest2()
        {
            // Arrange 
            NumberConverter nc = new NumberConverter();

            // Act 
            nc.RoundDown(18);

            // Assert
            Assert.AreEqual(18, 18);
        }
    }
}