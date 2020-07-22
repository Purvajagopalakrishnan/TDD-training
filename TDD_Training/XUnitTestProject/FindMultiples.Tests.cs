using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            FindMultiplesService findMultiplesService = new FindMultiplesService();

        [Theory]
        [InlineData(6)]
        [InlineData(93)]
        [InlineData(105)]
        public void CheckNumber_IfMultipleOfThree_ReturnsTrue(int value)
        {
            var expected = "Fizz";

            var actual = findMultiplesService.(value);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(101)]
        [InlineData(199)]
        public void CheckNumber_IfMultipleOfThree_ReturnsFalse(int value)
        {
            var expected = value;

            var actual = findMultiplesService.
            Assert.Equal(expected, actual);
        }
    }
}
    }
}
