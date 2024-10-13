namespace LeetCode.Challenges.ContainsDuplicate;

// Time Complexity: O(nlog(n)).
// Space Complexity: O(log(n)).
public class SortingSolution
{
    public bool ContainsDuplicate(int[] numbers)
    {
        Array.Sort(numbers);
        for (var i = 1; i < numbers.Length; i++)
        {
            if (numbers[i - 1] == numbers[i])
            {
                return true;
            }
        }

        return false;
    }
}
