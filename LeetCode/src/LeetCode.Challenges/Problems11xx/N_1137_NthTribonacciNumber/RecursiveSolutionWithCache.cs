namespace LeetCode.Challenges.Problems11xx.N_1137_NthTribonacciNumber;

public static class RecursiveSolutionWithCache
{
    public static int Tribonacci(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);

        var cache = new Dictionary<int, int>();
        return TribonacciInternal(n, ref cache);
    }

    private static int TribonacciInternal(int n, ref Dictionary<int, int> cache)
    {
        return n switch
        {
            0 => 0,
            <= 2 => 1,
            _ when cache.TryGetValue(n, out var val) => val,
            _ => cache[n] =
                TribonacciInternal(n - 3, ref cache) +
                TribonacciInternal(n - 2, ref cache) +
                TribonacciInternal(n - 1, ref cache)
        };
    }
}
