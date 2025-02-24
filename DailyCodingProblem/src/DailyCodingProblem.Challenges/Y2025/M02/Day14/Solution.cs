namespace DailyCodingProblem.Challenges.Y2025.M02.Day14;

public static class Solution
{
    public static bool VerifyCollatzSequence(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(n);

        if (n == 1)
        {
            return true;
        }

        while (n > 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = 3 * n + 1;
            }

            if (n == 1)
            {
                return true;
            }
        }

        return false;
    }
}
