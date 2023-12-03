using BeFaster.App.Solutions.CHK;
using Xunit;

namespace BeFaster.App.Tests.Solutions.CHK
{
    public class CheckoutSolutionTest
    {
        [Theory]
        [InlineData("E", -1)]
        [InlineData("ABCD", 115)]
        [InlineData("AAABBCCDD", 245)]
        [InlineData("AAAAAAABBBBBCCDD", 500)]
        public void ComputePrices_WhenCalled_ShouldReturnPrice(string skus, int expected)
        {
            // Act
            var price = CheckoutSolution.ComputePrice(skus);

            // Assert
            Assert.Equal(expected, price);
        }
    }
}
