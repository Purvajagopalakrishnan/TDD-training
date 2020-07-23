using System;
using TDD_Training;
using Xunit;

namespace FindMultiplesTests
{
    public class FindMultiplesTests
    {
        private readonly FizzBuzzService _findMultiples = new FizzBuzzService();

        [Fact]
        public void CheckGivenNumber_IfMultipleOfThree_ReturnsFizz()
        {
            //Arrange
            var value = 312;
            var expected = "Fizz";

            //Act
            var actual = _findMultiples.isMultipleOf(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(93)]
        [InlineData(108)]
        public void CheckNumber_IfMultipleOfThree_ReturnsFizz(int value)
        {
            //Arrange
            var expected = "Fizz";

            //Act
            var actual = _findMultiples.isMultipleOf(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(200)]
        [InlineData(215)]
        public void CheckNumber_IfMultipleOfFive_ReturnsBuzz(int value)
        {
            //Arrange
            var expected = "Buzz";

            //Act
            var actual = _findMultiples.isMultipleOf(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(300)]
        [InlineData(315)]
        public void CheckNumber_IfMultipleOfThreeOrFive_ReturnsFizzBuzz(int value)
        {
            //Arrange
            var expected = "FizzBuzz";

            //Act
            var actual = _findMultiples.isMultipleOf(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16.12)]
        [InlineData(214)]
        [InlineData(317)]
        public void CheckNumber_IfMultipleOfThreeOrFive_ReturnsGivenNumber(int value)
        {
            //Arrange
            var expected = Convert.ToString(value);

            //Act
            var actual = _findMultiples.isMultipleOf(value);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

