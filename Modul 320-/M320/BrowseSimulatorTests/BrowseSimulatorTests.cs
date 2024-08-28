using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrowseSimulator;

namespace BrowseSimulatorTests
{
    [TestClass]
    public class StringStackTests
    {
        [TestMethod]
        public void Push()
        {
            // Arrange
            StringStack stack = new StringStack();

            // Act
            stack.Push("www.apple.com");

            // Assert
            Assert.AreEqual("www.apple.com", stack.Peak());
        }

        [TestMethod]
        public void Push_Null()  // return Null wenn Stack Voll ist
        {
            // Arrange
            StringStack stack = new StringStack();

            // Fill the stack
            for (int i = 0; i < 10; i++)
            {
                stack.Push($"www.Example.com{i}.com");
            }

            // Act
            var result = stack.Push("www.apple.com");

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Pop()
        {
            // Arrange
            StringStack stack = new StringStack();
            stack.Push("www.apple.com");
            stack.Push("www.nike.com");

            // Act
            var result = stack.Pop();

            // Assert
            Assert.AreEqual("www.nike.com", result);
            Assert.AreEqual("www.apple.com", stack.Peak());
        }

        [TestMethod]
        public void Pop_Null() // return Null wenn Stack Leer ist
        {
            // Arrange
            StringStack stack = new StringStack();

            // Act
            var result = stack.Pop();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Peak()
        {
            // Arrange
            StringStack stack = new StringStack();
            stack.Push("www.apple.com");
            stack.Push("www.nike.com");

            // Act
            var result = stack.Peak();

            // Assert
            Assert.AreEqual("www.nike.com", result);
            Assert.AreEqual(2, stack.Count);
        }

        [TestMethod]
        public void Peak_Null() // return Null wenn Stack is Empty
        {
            // Arrange
            StringStack stack = new StringStack();

            // Act
            var result = stack.Peak();

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Clear()
        {
            // Arrange
            StringStack stack = new StringStack();
            stack.Push("www.apple.com");
            stack.Push("www.nike.com");

            // Act
            stack.Clear();

            // Assert
            Assert.AreEqual(0, stack.Count);
            Assert.IsTrue(stack.IsEmpty);
        }
    }
}
