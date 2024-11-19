namespace LeetCode.Challenges.Problems00xx.N_0014_LongestCommonPrefix;

public static class Solution
{
    // Explanation:
    // 1. If the input array is null or empty, return an empty string, as there's no prefix to find.
    // 2. Use the first string in the array as the initial prefix.
    // 3. For each subsequent string in the array:
    //    -- Check if it starts with the current prefix.
    //    -- If it does not, remove the last character from the prefix and recheck.
    //    -- Repeat this until the prefix matches the start of the current string or becomes empty.
    // 4. If at any point the prefix becomes empty, return an empty string (no common prefix exists).
    // 5. After all strings are processed, the prefix will contain the longest common prefix.
    public static string LongestCommonPrefix(string[] strings)
    {
        if (strings == null! || strings.Length == 0)
        {
            return string.Empty;
        }

        var prefix = strings[0];
        for (var i = 1; i < strings.Length; i++)
        {
            while (!strings[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (string.IsNullOrEmpty(prefix))
                {
                    return string.Empty;
                }
            }
        }

        return prefix;
    }
}
