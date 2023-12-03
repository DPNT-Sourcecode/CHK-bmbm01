using BeFaster.App.Solutions.CHK;
using Xunit;

namespace BeFaster.App.Tests.Solutions.CHK
{
    public class CheckoutSolutionTest
    {
        [Theory]
        [InlineData("F", -1)]
        [InlineData("ABCD", 115)]
        [InlineData("AAABBCCDD", 245)]
        [InlineData("AAAAAAABBBBBCCDD", 490)]
        [InlineData("AAAAAAABBBBBCCDDE", 530)]
        [InlineData("AAAAAAABBBBBCCDDEE", 540)]
        [InlineData("BEBEEE", 135)]
        //[InlineData("ABCDEABCDE", 540)]
        public void ComputePrices_WhenCalled_ShouldReturnPrice(string skus, int expected)
        {
            // Act
            var price = CheckoutSolution.ComputePrice(skus);

            // Assert
            Assert.Equal(expected, price);
        }
    }
}

