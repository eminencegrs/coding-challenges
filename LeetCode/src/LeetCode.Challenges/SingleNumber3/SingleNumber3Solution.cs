namespace LeetCode.Challenges.SingleNumber3;

// Time Complexity: O(n).
// Space Complexity: O(1).
public class SingleNumber3Solution
{
    public static int[] Get(int[] numbers)
    {
        // First, we XOR all numbers to get the XOR of the two unique numbers.
        int xorResult = numbers.Aggregate(0, (current, num) => current ^ num);

        // This identifies the rightmost bit (RMB) where the two unique numbers differ.
        int distinguishingBit = xorResult & -xorResult;

        int unique1 = 0;
        int unique2 = 0;

        foreach (var num in numbers)
        {
            if ((distinguishingBit & num) != 0)
            {
                unique1 ^= num;
            }
            else
            {
                unique2 ^= num;
            }
        }

        return [unique1, unique2];
    }
}
