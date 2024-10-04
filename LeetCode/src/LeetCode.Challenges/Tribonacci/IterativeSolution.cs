namespace LeetCode.Challenges.Tribonacci;

public class IterativeSolution
{
    public int Tribonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException("n");
        }

        if (n == 0)
        {
            return 0;
        }

        if (n <= 2)
        {
            return 1;
        }

        var t1 = 0;
        var t2 = 1;
        var t3 = 1;

        for (var i = 3; i <= n; i++)
        {
            var current = t1 + t2 + t3;
            t1 = t2;
            t2 = t3;
            t3 = current;
        }

        return t3;
    }
}
