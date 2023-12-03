using BeFaster.App.Solutions.HLO;
using Xunit;

namespace BeFaster.App.Tests.Solutions.HLO
{
    public class HelloSolutionTest
    {
        [Theory]
        [InlineData("John")]
        public void Hello_WhenCalled_ShouldReturnString(string friendName)
        {
            // Arrange
            var expected = "Hello, " + friendName + "!";

            // Act
            var result = HelloSolution.Hello(friendName);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
