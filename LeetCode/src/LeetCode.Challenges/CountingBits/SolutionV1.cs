namespace LeetCode.Challenges.CountingBits;

public class SolutionV1
{
    public static int[] CountBits(int n)
    {
        var answers = new int[n + 1];
        for (var item = 0; item <= n; item++)
        {
            var binary = Convert.ToString(item, 2);
            var a = binary.Count(x => x == '1');
            answers[item] = a;
        }

        return answers;
    }
}
