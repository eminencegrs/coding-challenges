using System.Security;

namespace LeetCode.Challenges.Problems00xx.N_0040_CombinationSumII;

public static class Solution
{
    public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        Array.Sort(candidates);

        Dfs(0, [], 0);

        return result;

        void Dfs(int start, IList<int> current, int total)
        {
            if (total == target)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (var i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1])
                {
                    continue;
                }

                if (total + candidates[i] > target)
                {
                    break;
                }

                current.Add(candidates[i]);
                Dfs(i + 1, current, total + candidates[i]);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
