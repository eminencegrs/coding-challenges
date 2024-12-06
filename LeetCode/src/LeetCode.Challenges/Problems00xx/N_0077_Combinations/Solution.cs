namespace LeetCode.Challenges.Problems00xx.N_0077_Combinations;

// Constraints:
//  - `1 <= n <= 20`
//  - `1 <= k <= n`
public static class Solution
{
    public static IList<IList<int>> Combine(int n, int k)
    {
        var result = new List<IList<int>>();
        Dfs(1, []);
        return result;

        void Dfs(int start, List<int> current)
        {
            if (current.Count == k)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (var x = start; x <= n; x++)
            {
                current.Add(x);
                Dfs(x + 1, current);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}
