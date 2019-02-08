using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BeingCraftsman.FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzGeneratorTests
    {
        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(33)]
        [DataRow(99)]
        public void ShouldReturnStringFizzWhenGivenNumberIsDivisibleBy3(int input)
        {
            string actual = FizzBuzzGenerator.Generate(input);
            string expected = "Fizz";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(10)]
        [DataRow(20)]
        [DataRow(40)]
        [DataRow(100)]
        public void ShouldReturnStringBuzzWhenGivenNumberIsDivisibleBy5(int input)
        {
            string actual = FizzBuzzGenerator.Generate(input);
            string expected = "Buzz";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        [DataRow(90)]
        [DataRow(150)]
        public void ShouldReturnStringFizzBuzzWhenGivenNumberIsDivisibleBy3And5(int input)
        {
            string actual = FizzBuzzGenerator.Generate(input);
            string expected = "FizzBuzz";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldReturnInputAsStringWhenGivenNumberIsNeitherDivisibleBy3or5()
        {
            int input = 17;
            string actual = FizzBuzzGenerator.Generate(input);
            string expected = "17";
            Assert.AreEqual(expected, actual);
        }
    }
}
