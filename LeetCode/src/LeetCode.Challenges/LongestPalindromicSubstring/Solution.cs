namespace LeetCode.Challenges.LongestPalindromicSubstring;

public class Solution
{
    public static string GetTheLongestPalindrome(string initialString)
    {
        if (string.IsNullOrWhiteSpace(initialString) || initialString.Length == 1)
        {
            return initialString;
        }

        var theLongestPalindrome = string.Empty;
        var initialLength = initialString.Length;
        for (var k = 0; k < initialLength; k++)
        {
            var attempt1 = ExpandAroundCenter(initialString, k, k);
            if (attempt1.Length > theLongestPalindrome.Length)
            {
                theLongestPalindrome = attempt1;
            }

            var attempt2 = ExpandAroundCenter(initialString, k, k + 1);
            if (attempt2.Length > theLongestPalindrome.Length)
            {
                theLongestPalindrome = attempt2;
            }
        }

        return theLongestPalindrome;
    }

    private static string ExpandAroundCenter(string originalString, int left, int right)
    {
        while (left >= 0 && right < originalString.Length && originalString[left] == originalString[right])
        {
            left--;
            right++;
        }

        return originalString.Substring(left + 1, right - left - 1);
    }
}