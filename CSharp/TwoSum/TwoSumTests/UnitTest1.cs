using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSumApp;

namespace TwoSumTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTwoSum_ReturnsCorrectIndices()
        {
            // Arrange
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;

            // Act
            int[] result = Program.TwoSum(numbers, target);

            // Assert
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void TestTwoSum_NoSolution()
        {
            // Arrange
            int[] numbers = { 1, 2, 3 };
            int target = 10;

            // Act
            int[] result = Program.TwoSum(numbers, target);

            // Assert
            Assert.AreEqual(0, result.Length);
        }
    }
}
