namespace LeetCode.Challenges.Pow;

public static class Solution
{
    // It is based on the Exponentiation by Squaring method.
    // Time Complexity: O(logn).
    public static double GetResult(double x, int n)
    {
        return (x, n) switch
        {
            (_, n: 0) => 1.0,
            (x: 0, _) => 0.0,
            (x: 1, _) => 1.0,
            _ => ComputePower(x, n)
        };
    }

    private static double ComputePower(double x, int n)
    {
        double result = 1.0;
        long counter = Math.Abs((long)n);
        while (counter > 0)
        {
            if (counter % 2 == 1)
            {
                result *= x;
            }

            x *= x;
            counter /= 2;
        }

        return Math.Round(n < 0 ? 1.0 / result : result, 5);
    }
}
