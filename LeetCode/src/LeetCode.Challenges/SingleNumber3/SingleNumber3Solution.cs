namespace LeetCode.Challenges.SingleNumber3;

// Time Complexity: O(n).
// Space Complexity: O(1).
public class SingleNumber3Solution
{
    public static int[] Get(int[] numbers)
    {
        int xorResult = numbers.Aggregate(0, (current, num) => current ^ num);

        int distinguishingBit = -xorResult & xorResult;

        int firstItem = 0;
        int secondItem = 0;

        foreach (var num in numbers)
        {
            if ((distinguishingBit & num) != 0)
            {
                firstItem ^= num;
            }
            else
            {
                secondItem ^= num;
            }
        }

        return [firstItem, secondItem];
    }
}
