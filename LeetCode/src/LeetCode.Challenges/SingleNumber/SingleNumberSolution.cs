namespace LeetCode.Challenges.SingleNumber;

// Time Complexity: O(n).
// Space Complexity: O(1).
public class SingleNumberSolution
{
    public static int Get(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException($"The array '{nameof(numbers)}' must not be empty.");
        }

        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result ^= numbers[i];
        }

        return result;
    }
}
