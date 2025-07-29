using NUnit.Framework;

namespace ConsoleApp.Tests
{
    /// <summary>
    /// Unit tests for the SquareSum functionality
    /// </summary>
    [TestFixture]
    public class SquareSumTests
    {
        [Test]
        public void SquareSum_WithValidNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int[] numbers = { 1, 2, 2 };
            int expected = 1 + 4 + 4; // 1² + 2² + 2² = 9
            
            // Act
            int result = Program.SquareSum(numbers);
            
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SquareSum_WithEmptyArray_ReturnsZero()
        {
            // Arrange
            int[] numbers = { };
            
            // Act
            int result = Program.SquareSum(numbers);
            
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void SquareSum_WithNullArray_ReturnsZero()
        {
            // Arrange
            int[]? numbers = null;
            
            // Act
            int result = Program.SquareSum(numbers!);
            
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void SquareSum_WithSingleElement_ReturnsSquareOfElement()
        {
            // Arrange
            int[] numbers = { 5 };
            int expected = 25; // 5² = 25
            
            // Act
            int result = Program.SquareSum(numbers);
            
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void SquareSum_WithNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int[] numbers = { -2, 3, -1 };
            int expected = 4 + 9 + 1; // (-2)² + 3² + (-1)² = 14
            
            // Act
            int result = Program.SquareSum(numbers);
            
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
