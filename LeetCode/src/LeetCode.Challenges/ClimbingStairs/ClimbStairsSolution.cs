namespace LeetCode.Challenges.ClimbingStairs;

public static class ClimbStairsSolution
{
    public static int GetResult(int n)
    {
        var cache = new Dictionary<int, int>();
        return Climb(n, cache);
    }

    private static int Climb(int n, IDictionary<int, int> cache)
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

        cache[n] = Climb(n - 1, cache) + Climb(n - 2, cache);
        return cache[n];
    }
}
