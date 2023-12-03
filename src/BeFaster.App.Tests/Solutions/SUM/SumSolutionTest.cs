using BeFaster.App.Solutions.SUM;
using System;
using Xunit;

namespace BeFaster.App.Tests.Solutions.SUM
{
    public class SumSolutionTest
    {
        [Theory]
        [InlineData(5, 10)]
        public void Sum_WithCorrectValues_ShouldReturnSummedValue(int x, int y)
        {
            // Arrange
            var expected = x + y;

            // Act
            var sum = SumSolution.Sum(x, y);

            // Assert
            Assert.Equal(expected, sum);
        }

        [Theory]
        [InlineData(-5, 10)]
        [InlineData(5, -10)]
        [InlineData(-5, -10)]
        public void Sum_WithIncorrectValues_ShouldThrowException(int x, int y)
        {
            var exception = Assert.Throws<Exception>(() => SumSolution.Sum(x, y));
            Assert.Equal("Value is out of range. It should be a number between 0-100.", exception.Message);
        }
    }
}
