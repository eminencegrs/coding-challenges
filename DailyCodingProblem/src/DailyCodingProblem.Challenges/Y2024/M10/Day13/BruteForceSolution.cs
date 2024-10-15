namespace DailyCodingProblem.Challenges.Y2024.M10.Day13;

// This question was asked by ContextLogic.
// Implement division of two positive integers without using
// the division, multiplication, or modulus operators.
// Return the quotient as an integer, ignoring the remainder.
public static class BruteForceSolution
{
    public static int Divide2PositiveIntegers(int dividend, int divisor)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(dividend, nameof(dividend));
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(divisor, nameof(divisor));

        if (dividend == 0)
        {
            return dividend;
        }

        if (divisor == 1)
        {
            return dividend;
        }

        if (divisor > dividend)
        {
            return 0;
        }

        var result = 0;
        while (dividend >= divisor)
        {
            dividend -= divisor;
            result++;
        }

        return result;
    }
}
