namespace LeetCode.Challenges.ClimbingStairs.V1;

// Time Complexity is O(n), as the maximum depth of the recursion stack is still O(n)  
// because the deepest chain of recursive calls can go from `Climb(n)` down to `Climb(0)`.
// Space Complexity is O(n), the cache stores the results of each subproblem,
// requiring O(n) space for the dictionary to hold the results of the `n + 1` subproblems. 
public static class RecursiveWithMemoSolution
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
