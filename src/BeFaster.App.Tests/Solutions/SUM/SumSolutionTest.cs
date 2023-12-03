using BeFaster.App.Solutions.SUM;
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
    }
}

