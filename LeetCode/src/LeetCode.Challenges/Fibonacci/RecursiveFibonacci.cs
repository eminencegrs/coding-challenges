namespace LeetCode.Challenges.Fibonacci;

// Time Complexity: O(n).
// Space Complexity: O(n).
public static class RecursiveFibonacci
{
    public static int GetResult(int n)
    {
        var cache = new Dictionary<int, int>();
        return Fibonacci(n, ref cache);
    }

    private static int Fibonacci(int n, ref Dictionary<int, int> cache)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        if (cache.TryGetValue(n, out var val))
        {
            return val;
        }

        cache[n] = Fibonacci(n - 2, ref cache) + Fibonacci(n - 1, ref cache);
        return cache[n];
    }
}
