namespace LeetCode.Challenges.Problems00xx.N_0039_CombinationSum;

public static class Solution
{
    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();
        Dfs(0, [], 0);
        return result;

        void Dfs(int index, List<int> current, int total)
        {
            if (total == target)
            {
                result.Add(current.ToList());
                return;
            }

            if (index >= candidates.Length || total > target)
            {
                return;
            }

            current.Add(candidates[index]);
            Dfs(index, current, total + candidates[index]);

            current.Remove(candidates[index]);
            Dfs(index + 1, current, total);
        }
    }
}
