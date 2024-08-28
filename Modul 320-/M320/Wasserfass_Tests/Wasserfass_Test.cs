namespace Wasserfass_Tests
{
    using Wasserfass;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Wasserfass_Test
    {
        [TestMethod]
        public void Befuellen()
        {
            // Arrange
            Wasserfass wasserfass = new Wasserfass(100, 200, 250);
            int menge = 10;

            // Act
            wasserfass.Befuellen(menge);

            // Assert
            Assert.AreEqual(menge, wasserfass.Fuellstand);
        }

        [TestMethod]
        public void Entnehmen()
        {
            // Arrange 
            Wasserfass wasserfass = new Wasserfass(100, 200, 250);
            wasserfass.Befuellen(100);

            // Act
            wasserfass.Entnehmen(110); // Try to take out 110 units, which is more than available.

            // Assert 
            Assert.AreEqual(100, wasserfass.Fuellstand); // The water level should remain the same.
        }

        [TestMethod]
        public void Entleeren()
        {
            // Arrange 
            Wasserfass wasserfass = new Wasserfass(100, 200, 250);
            wasserfass.Befuellen(20);

            // Act
            wasserfass.Entleeren();

            // Assert
            Assert.AreEqual(0, wasserfass.Fuellstand);
        }
    }
}