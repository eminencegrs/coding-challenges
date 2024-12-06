namespace LeetCode.Challenges.Problems25xx.N_2554_MaximumNumberOfIntegersToChooseFromRangeI;

public static class GreedyApproach
{
    public static int MaxCount(int[] banned, int n, int maxSum)
    {
        var bannedSet = new HashSet<int>(banned);
        var currentSum = 0;
        var resultCount = 0;

        for (var number = 1; number <= n; number++)
        {
            if (bannedSet.Contains(number))
            {
                continue;
            }

            if (currentSum + number > maxSum)
            {
                break;
            }

            currentSum += number;
            resultCount++;
        }

        return resultCount;
    }
}
