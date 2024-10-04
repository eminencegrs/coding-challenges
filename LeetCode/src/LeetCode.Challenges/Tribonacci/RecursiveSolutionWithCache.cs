namespace LeetCode.Challenges.Tribonacci;

public class RecursiveSolutionWithCache
{
    public int Tribonacci(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);

        var cache = new Dictionary<int, int>();
        return this.TribInternal(n, ref cache);
    }

    private int TribInternal(int n, ref Dictionary<int, int> cache)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n <= 2)
        {
            return 1;
        }

        if (cache.TryGetValue(n, out var val))
        {
            return val;
        }

        cache[n] = this.TribInternal(n - 3, ref cache) + 
                   this.TribInternal(n - 2, ref cache) + 
                   this.TribInternal(n - 1, ref cache);

        return cache[n];
    }
}
