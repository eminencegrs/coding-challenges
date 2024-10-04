namespace LeetCode.Challenges.Tribonacci;

public class IterativeSolution
{
    public int Tribonacci(int n)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(n);

        return n switch
        {
            0 => 0,
            <= 2 => 1,
            _ => this.TribInternal(n)
        };
    }

    private int TribInternal(int n)
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
