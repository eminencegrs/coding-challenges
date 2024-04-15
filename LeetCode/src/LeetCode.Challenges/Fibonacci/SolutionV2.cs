namespace LeetCode.Challenges.Fibonacci;

// Time Complexity: O(n)
// Space Complexity: O(1) - because we don't use any data structure that depends on the input `n`.
public class SolutionV2
{
    public int Fib(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        var prev1 = 0;
        var prev2 = 1;

        for (var i = 2; i <= n; i++)
        {
            var current = prev1 + prev2;
            prev1 = prev2;
            prev2 = current;
        }

        return prev2;
    }
}
