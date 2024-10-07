namespace LeetCode.Challenges.ClimbingStairs.V3;

public static class Solution
{
    public static int ClimbStairs(int staircaseLength, int[] stepSizes)
    {
        var cache = new Dictionary<int, int>();
        return Climb(staircaseLength, stepSizes, cache);
    }

    private static int Climb(int n, int[] stepSizes, IDictionary<int, int> cache)
    {
        if (n < 0)
        {
            return 0;
        }

        if (n == 0)
        {
            return 1;
        }

        if (cache.TryGetValue(n, out var value))
        {
            return value;
        }

        cache[n] = stepSizes.Sum(step => Climb(n - step, stepSizes, cache));
        return cache[n];
    }
}
