namespace LeetCode.Challenges.Problems00xx.N_0090_SubsetsII;

public static class Solution
{
    public static IList<IList<int>> Subsets(int[] numbers)
    {
        var result = new List<IList<int>>();
        Dfs(0, []);
        return result;

        void Dfs(int index, IList<int> subset)
        {
            if (index == numbers.Length)
            {
                result.Add(new List<int>(subset));
                return;
            }

            subset.Add(numbers[index]);
            Dfs(index + 1, subset);

            subset.RemoveAt(subset.Count - 1);

            while (index + 1 < numbers.Length && numbers[index] == numbers[index + 1])
            {
                index++;
            }

            Dfs(index + 1, subset);
        }
    }
}
