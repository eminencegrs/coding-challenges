namespace LeetCode.Challenges.Problems00xx.N_0046_Permutations;

// Please, note: there are 3 keys points of backtracking:
//  - choices: the range of decisions at each step.
//  - constraints: the rules to filter valid choices.
//  - goal: the condition to stop recursion.
public static class Solution
{
    public static IList<IList<int>> Permute(int[] numbers)
    {
        var result = new List<IList<int>>();
        var used = new bool[numbers.Length];
        Dfs([]);
        return result;

        void Dfs(IList<int> current)
        {
            // Base case: all numbers are included in the current permutation.
            if (current.Count == numbers.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                // Skip used numbers.
                if (used[i])
                {
                    continue;
                }

                // Choose the current number and mark it as used.
                used[i] = true;
                current.Add(numbers[i]);

                // Recurse to build the next step of the permutation.
                Dfs(current);

                // Backtrack: undo the choice.
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }
    }
}
