namespace LeetCode.Challenges.PlusOne;

// Time Complexity: O(n).
// Space Complexity: O(n) - in the worst case, when all digits are 9, a new array is created.
// In other cases, the array is modified in place, so the space complexity is O(1).
public static class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }

            digits[i] = 0;
        }

        var result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}
