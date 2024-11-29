namespace LeetCode.Challenges.Problems00xx.N_0077_Combinations;

public class Backtracking
{
    private readonly List<IList<int>> result = [];

    public IList<IList<int>> Combine(int n, int k)
    {
        this.Backtrack(1, n, k, []);
        return this.result;
    }

    private void Backtrack(int start, int n, int k, List<int> combination)
    {
        if (combination.Count == k)
        {
            this.result.Add(new List<int>(combination));
            return;
        }

        for (var x = start; x <= n; x++)
        {
            combination.Add(x);
            this.Backtrack(x + 1, n, k, combination);
            combination.RemoveAt(combination.Count - 1);
        }
    }
}
