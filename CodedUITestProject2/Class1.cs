using ConsoleApplication1;

namespace StringExtensionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringExtensionIsBlueAPrimaryColorTest()
        {
            // Arrange
            string color = "Blue";

            // Act
            bool actual = color.IsPrimaryColor();

            // Assert
            const bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringExtensionIsRedAPrimaryColorTest()
        {
            // Arrange
            string color = "Red";

            // Act
            bool actual = color.IsPrimaryColor();

            // Assert
            const bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringExtensionIsYellowAPrimaryColorTest()
        {
            // Arrange
            string color = "Yellow";

            // Act
            bool actual = color.IsPrimaryColor();

            // Assert
            const bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringExtensionIsBlackAPrimaryColorTest()
        {
            // Arrange
            string color = "Black";

            // Act
            bool actual = color.IsPrimaryColor();

            // Assert
            const bool expected = false;
            Assert.AreEqual(expected, actual);
        }
    }
}
