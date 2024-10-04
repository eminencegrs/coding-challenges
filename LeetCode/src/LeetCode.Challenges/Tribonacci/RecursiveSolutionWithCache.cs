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
        return n switch
        {
            0 => 0,
            <= 2 => 1,
            _ when cache.TryGetValue(n, out var val) => val,
            _ => cache[n] =
                this.TribInternal(n - 3, ref cache) +
                this.TribInternal(n - 2, ref cache) +
                this.TribInternal(n - 1, ref cache)
        };
    }
}
