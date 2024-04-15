namespace LeetCode.Challenges.Fibonacci;

// Time Complexity: O(n)
// Space Complexity: O(n)
public class SolutionV1
{
    public int Fib(int n)
    {
        var cache = new Dictionary<int, int>();
        return Fib(n, cache);
    }

    private int Fib(int n, IDictionary<int, int> cache)
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

        cache[n] = this.Fib(n - 2, cache) + this.Fib(n - 1, cache);
        return cache[n];
    }
}
