namespace LeetCode.Challenges.Problems00xx.N_0046_Permutations;

// Notes:
// There are 3 keys points of backtracking:
//  - choices: the range of decisions at each step.
//  - constraints: the rules to filter valid choices.
//  - goal: the condition to stop recursion.
public static class Solution
{
    public static IList<IList<int>> Permute(int[] numbers)
    {
        var result = new List<IList<int>>();
        Dfs([]);
        return result;

        void Dfs(HashSet<int> current)
        {
            // Base case: all numbers are included in the current permutation.
            if (current.Count == numbers.Length)
            {
                result.Add(current.ToList());
                return;
            }

            foreach (var number in numbers)
            {
                // Skip already used numbers.
                if (current.Contains(number))
                {
                    continue;
                }

                // Add the number to the current permutation.
                current.Add(number);

                // Recurse to build the next step of the permutation.
                Dfs(current);

                // Backtrack: remove the last choice to explore others.
                current.Remove(number);
            }
        }
    }
}
