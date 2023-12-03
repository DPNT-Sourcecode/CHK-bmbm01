using BeFaster.Runner.Exceptions;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.CHK
{
    public static class CheckoutSolution
    {
        private static readonly Dictionary<string, int> Prices = new Dictionary<string, int>()
        {
            { "A", 50 },
            { "B", 30 },
            { "C", 20 },
            { "D", 15 },
        };

        public static int ComputePrice(string skus)
        {
            throw new SolutionNotImplementedException();
        }
    }
}

