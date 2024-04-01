namespace LeetCode.Challenges.CountingBits;

public class SolutionV2
{
    public static int[] CountBits(int n)
    {
        var answers = new int[n + 1];
        for (var item = 0; item <= n; item++)
        {
            answers[item] = CountOnes(item);
        }

        return answers;
    }

    public static int CountOnes(int number)
    {
        var count = 0;
        while (number != 0)
        {
            count += number & 1;
            number >>= 1;
        }

        return count;
    }
}
