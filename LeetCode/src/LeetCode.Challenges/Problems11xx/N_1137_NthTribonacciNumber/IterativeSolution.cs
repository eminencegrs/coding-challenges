namespace LeetCode.Challenges.Problems11xx.N_1137_NthTribonacciNumber;

public static class IterativeSolution
{
    public static int Tribonacci(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);

        return n switch
        {
            0 => 0,
            <= 2 => 1,
            _ => TribonacciInternal(n)
        };
    }

    private static int TribonacciInternal(int n)
    {
        var firstItem = 0;
        var secondItem = 1;
        var thirdItem = 1;

        for (var i = 3; i <= n; i++)
        {
            var current = firstItem + secondItem + thirdItem;
            firstItem = secondItem;
            secondItem = thirdItem;
            thirdItem = current;
        }

        return thirdItem;
    }
}
