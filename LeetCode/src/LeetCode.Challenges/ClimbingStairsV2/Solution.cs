namespace LeetCode.Challenges.ClimbingStairsV2;

public class Solution
{
    public int ClimbStairs(int n)
    {
        var cache = new Dictionary<int, int>();
        return this.Climb(n, cache);
    }

    private int Climb(int n, IDictionary<int, int> cache)
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

        cache[n] = this.Climb(n - 1, cache) + this.Climb(n - 2, cache) + this.Climb(n - 3, cache);
        return cache[n];
    }
}
