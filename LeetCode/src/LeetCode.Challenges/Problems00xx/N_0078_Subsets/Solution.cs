namespace LeetCode.Challenges.Problems00xx.N_0078_Subsets;

public static class Solution
{
    public static IList<IList<int>> Subsets(int[] numbers)
    {
        var result = new List<IList<int>>();
        Dfs(0, []);
        return result;

        void Dfs(int start, IList<int> current)
        {
            for (var i = start; i < numbers.Length; i++)
            {
                current.Add(numbers[i]);
                Dfs(i + 1, current);
                current.RemoveAt(current.Count - 1);
            }

            result.Add(new List<int>(current));
        }
    }
}
