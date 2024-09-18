namespace DailyCodingProblem.Challenges.Y2024.M09;

// This problem was asked by Google.
// 
// Implement integer exponentiation.
// That is, implement the `pow(x, y)` function, where `x` and `y` are integers and returns `x^y`.
// Do it faster than the naive method of repeated multiplication.
// 
// For example, `pow(2, 10)` should return `1024`.
//
// Time Complexity:
//  -- O(n) - is not acceptable.
public static class Day16Task
{
    public static double RecursivePow(int x, int n)
    {
        // First, we take the absolute value of the exponent `n` to handle negative exponents.
        // We will adjust the result later to account for the sign of the original exponent.
        var result = GetResultRecursively(x, Math.Abs(n));

        // If the original exponent was negative, we return the reciprocal of the result.
        return n < 0 ? 1 / result : result;
    }

    private static double GetResultRecursively(int x, int n)
    {
        if (x == 0) return 0;
        if (n == 0) return 1;

        var result = RecursivePow(x * x, n / 2);
        return n % 2 == 0 ? result : result * x;
    }
}
