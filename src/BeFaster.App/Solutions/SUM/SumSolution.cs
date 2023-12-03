using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        private static readonly int LowerBound = 0;
        private static readonly int UpperBound = 100;

        public static int Sum(int x, int y)
        {
            CheckValidValue(x);
            CheckValidValue(y);

            return x + y;
        }

        private static void CheckValidValue(int value)
        {
            if (value < LowerBound || value > UpperBound)
            {
                throw new System.Exception("Value is out of range. It should be a number between 0-100.");
            }
        }
    }
}
