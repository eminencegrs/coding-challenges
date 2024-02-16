namespace LeetCode.Challenges.LongestSubstringWithoutRepeating;

public class Solution
{
    public int GetLongestSubstringLength(string input)
    {
        var maxIterations = input.Length;

        // Using HashSet allows us to efficiently handle the task of identifying repeating characters
        // within the sliding window as we traverse the string from left to right.
        // This contributes to the overall efficiency and correctness of the algorithm
        // for finding the length of the longest substring without repeating characters.
        var substring = new HashSet<char>();
        var longestSubstringLength = 0;
        var leftBoundaryIndex = 0;
        var rightBoundaryIndex = 0;

        while (leftBoundaryIndex < maxIterations && rightBoundaryIndex < maxIterations)
        {
            if (!substring.Contains(input[rightBoundaryIndex]))
            {
                substring.Add(input[rightBoundaryIndex++]);
                longestSubstringLength = Math.Max(longestSubstringLength, rightBoundaryIndex - leftBoundaryIndex);
            }
            else
            {
                substring.Remove(input[leftBoundaryIndex++]);
            }
        }

        return longestSubstringLength;
    }
}
