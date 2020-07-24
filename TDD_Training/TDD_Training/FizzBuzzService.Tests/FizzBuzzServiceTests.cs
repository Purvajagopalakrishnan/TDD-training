using System;
using TDD_Training;
using Xunit;

namespace FizzBuzzServiceTests
{
    public class FizzBuzzServiceTests
    {
        private readonly FizzBuzzService _fizzBuzzService = new FizzBuzzService();

        [Theory]
        [InlineData(6)]
        [InlineData(93)]
        [InlineData(108)]
        public void GivenNumberInMultipleOfThree_IsMultipleOf_ReturnsFizz(int value)
        {
            //Arrange
            var expected = "Fizz";

            //Act
            var actual = _fizzBuzzService.CheckFizzBuzz(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(200)]
        [InlineData(215)]
        public void GivenNumberInMultipleOfFive_IsMultipleOf_ReturnsBuzz(int value)
        {
            //Arrange
            var expected = "Buzz";

            //Act
            var actual = _fizzBuzzService.CheckFizzBuzz(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(300)]
        [InlineData(315)]
        public void GivenNumberInMultipleOfThreeAndFive_IsMultipleOf_ReturnsFizzBuzz(int value)
        {
            //Arrange
            var expected = "FizzBuzz";

            //Act
            var actual = _fizzBuzzService.CheckFizzBuzz(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16.12)]
        [InlineData(214)]
        [InlineData(317)]
        public void GivenNumberIsNotMultipleOfThreeOrFive_IsMultipleOf_ReturnsGivenNumber(int value)
        {
            //Arrange
            var expected = Convert.ToString(value);

            //Act
            var actual = _fizzBuzzService.CheckFizzBuzz(value);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

