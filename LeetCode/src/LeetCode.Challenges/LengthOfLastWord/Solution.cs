namespace LeetCode.Challenges.LengthOfLastWord;

public class Solution
{
    // The complexity is O(n).
    public static int GetLengthOfLastWordV1(string s)
    {
        return s.Split(' ').Last().Length;
    }

    // The complexity is O(1).
    public static int GetLengthOfLastWordV2(string phrase)
    {
        var length = 0;
        var index = phrase.Length - 1;

        // Skip trailing whitespace. 
        while (index >= 0 && phrase[index] == ' ')
        {
            index--;
        }

        // Count characters of the last word until the first space or the beginning of the string.
        while (index >= 0 && phrase[index] != ' ')
        {
            length++;
            index--;
        }

        return length;
    }
}
