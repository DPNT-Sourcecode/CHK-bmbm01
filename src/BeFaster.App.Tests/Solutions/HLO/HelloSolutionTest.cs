using BeFaster.App.Solutions.HLO;
using Xunit;

namespace BeFaster.App.Tests.Solutions.HLO
{
    public class HelloSolutionTest
    {
        [Fact]
        public void Hello_WhenCalled_ShouldReturnString()
        {
            // Arrange
            const string expected = "Hello, World!";

            // Act
            var result = HelloSolution.Hello("");

            // Assert
            Assert.Equal(expected, result);
        }
    }
}


