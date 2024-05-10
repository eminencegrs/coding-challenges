namespace LeetCode.Challenges.IsSubsequence;

public class Solution
{
    public bool IsSubsequence(string substring, string originalString)
    {
        if (string.IsNullOrEmpty(substring))
        {
            return true;
        }

        var sPointer = 0;
        var oPointer = 0;

        while (oPointer < originalString.Length && sPointer < substring.Length)
        {
            if (substring[sPointer] == originalString[oPointer])
            {
                sPointer++;
            }

            oPointer++;
        }

        return sPointer == substring.Length;
    }
}
