namespace LeetCode.Challenges.Problems00xx.N_0046_Permutations;

// Please, note: there are 3 keys points of backtracking:
//  - choices: the range of decisions at each step.
//  - constraints: the rules to filter valid choices.
//  - goal: the condition to stop recursion.
public static class SolutionV1
{
    public static IList<IList<int>> Permute(int[] numbers)
    {
        var result = new List<IList<int>>();
        Dfs([]);
        return result;

        void Dfs(HashSet<int> current)
        {
            if (current.Count == numbers.Length)
            {
                result.Add(current.ToList());
                return;
            }

            foreach (var number in numbers)
            {
                if (!current.Add(number)) continue;

                Dfs(current);

                current.Remove(number);
            }
        }
    }
}
