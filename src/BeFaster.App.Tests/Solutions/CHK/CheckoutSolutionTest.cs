using BeFaster.App.Solutions.CHK;
using Xunit;

namespace BeFaster.App.Tests.Solutions.CHK
{
    public class CheckoutSolutionTest
    {
        [Theory]
        //[InlineData("1", -1)]
        //[InlineData("ABCD", 115)]
        //[InlineData("AAABBCCDD", 245)]
        //[InlineData("AAAAAAABBBBBCCDD", 490)]
        //[InlineData("AAAAAAABBBBBCCDDE", 530)]
        //[InlineData("AAAAAAABBBBBCCDDEE", 540)]
        //[InlineData("EEB", 80)]
        //[InlineData("EEEB", 120)]
        //[InlineData("EEEEBB", 160)]
        //[InlineData("AAAAAAABBBBBCCDDEEFF", 560)]
        //[InlineData("AAAAAAABBBBBCCDDEEFFF", 560)]
        //[InlineData("AAAAAAABBBBBCCDDEEFFFF", 570)]
        //[InlineData("UUU", 120)]
        //[InlineData("XXXYYYZZZ", 135)]
        //[InlineData("XXXXYYYYZZZ", 169)]
        //[InlineData("ABCDEFGHIJKLMNOPQRSTUVW", 795)]
        //[InlineData("CXYZYZC", 122)]
        //[InlineData("STX", 45)]
        //[InlineData("SSS", 45)]
        [InlineData("SSSZ", 65)]
        public void ComputePrices_WhenCalled_ShouldReturnPrice(string skus, int expected)
        {
            // Act
            var price = CheckoutSolution.ComputePrice(skus);

            // Assert
            Assert.Equal(expected, price);
        }
    }
}




