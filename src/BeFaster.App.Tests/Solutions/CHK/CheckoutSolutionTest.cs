using BeFaster.App.Solutions.CHK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BeFaster.App.Tests.Solutions.CHK
{
    public class CheckoutSolutionTest
    {
        [Theory]
        [InlineData("D", -1)]
        [InlineData("ABCD", -1)]
        [InlineData("AAABBCCDD", -1)]
        [InlineData("AAAAAAABBBBBCCDD", -1)]
        public void ComputePrices_WhenCalled_ShouldReturnPrice(string skus, int expected)
        {
            // Act
            var price = CheckoutSolution.ComputePrice(skus);

            // Assert
            Assert.Equal(expected, price);
        }
    }
}

