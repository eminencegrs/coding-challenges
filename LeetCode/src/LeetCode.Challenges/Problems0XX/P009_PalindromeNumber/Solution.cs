namespace LeetCode.Challenges.Problems0XX.P009_PalindromeNumber;

public static class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        List<int> digits = [];
        while (x >= 1)
        {
            digits.Add(x % 10);
            x /= 10;
        }

        var left = 0;
        var right = digits.Count - 1;

        while (left <= right)
        {
            if (digits[left] != digits[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}
