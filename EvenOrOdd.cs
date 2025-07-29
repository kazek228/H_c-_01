using System.Runtime;
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
        public void Odd_Number()
        {
            int input = 9;
            string expect_result = "Odd";
            string result = Program.EvenOrOdd(input);

            Assert.That(expect_result, Is.EqualTo(result));
        }

        [Test]
        public void Even_Number()
        {
            int input = 4;
            string expect_result = "Even";
            string result = Program.EvenOrOdd(input);

            Assert.That(expect_result, Is.EqualTo(result));
        }

        [Test]
        public void Even_Negative_Number()
        {
            int input = -1;
            string expect_result = "Odd";
            string result = Program.EvenOrOdd(input);

            Assert.That(expect_result, Is.EqualTo(result));
        }
    }
}
