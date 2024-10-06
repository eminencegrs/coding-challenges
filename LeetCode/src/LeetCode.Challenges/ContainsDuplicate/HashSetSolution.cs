namespace LeetCode.Challenges.ContainsDuplicate;

// Time Complexity: O(n).
// Space Complexity: O(n).
public class HashSetSolution
{
    public bool ContainsDuplicate(int[] numbers)
    {
        var set = new HashSet<int>();
        return numbers.Any(num => !set.Add(num));
    }
}
