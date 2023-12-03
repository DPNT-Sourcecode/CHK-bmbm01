using BeFaster.App.Solutions.SUM;
using Xunit;

namespace BeFaster.App.Tests.Solutions.SUM
{
    public class SumSolutionTest
    {
        [Fact]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }
    }
}
