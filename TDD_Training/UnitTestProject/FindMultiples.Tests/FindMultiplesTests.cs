using System;
using System.Text;
using System.Collections.Generic;
using Xunit;
using System.Threading.Tasks;

namespace UnitTestProject.FindMultiples.Tests
{
    /// <summary>
    /// Summary description for FindMultiplesTests
    /// </summary>
    public class FindMultiplesTests
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
