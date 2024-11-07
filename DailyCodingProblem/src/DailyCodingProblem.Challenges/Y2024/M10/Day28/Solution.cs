namespace DailyCodingProblem.Challenges.Y2024.M10.Day28;

// This problem was asked by Square.
// Given a string and a set of characters.
// Return the shortest substring containing all the characters in the set.
// For example, given the string "figehaeci" and the set of characters {a, e, i}, you should return "aeci".
// If there is no substring containing all the characters in the set, return null.
public class Solution
{
    // TODO: Investigate why the unit tests fail.
    public string MinWindow(string input, string characters)
    {
        if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(characters) || input.Length < characters.Length)
        {
            return string.Empty;
        }

        var requiredCount = new Dictionary<char, int>();
        foreach (var c in characters)
        {
            if (!requiredCount.TryAdd(c, 1))
            {
                requiredCount[c]++;
            }
        }

        var left = 0;
        var matched = 0;
        var minLength = int.MaxValue;
        var minStart = 0;
        var windowCount = new Dictionary<char, int>();

        for (var right = 0; right < input.Length; right++)
        {
            var currentChar = input[right];

            if (requiredCount.ContainsKey(currentChar))
            {
                if (windowCount.ContainsKey(currentChar))
                {
                    windowCount[currentChar]++;
                }
                else
                {
                    windowCount[currentChar] = 1;
                }

                if (windowCount[currentChar] == requiredCount[currentChar])
                {
                    matched++;
                }
            }

            while (matched == requiredCount.Count)
            {
                var windowLength = right - left + 1;
                if (windowLength < minLength)
                {
                    minLength = windowLength;
                    minStart = left;
                }

                var leftChar = input[left];
                if (requiredCount.ContainsKey(leftChar))
                {
                    if (windowCount[leftChar] == requiredCount[leftChar])
                    {
                        matched--;
                    }

                    windowCount[leftChar]--;
                }

                left++;
            }
        }

        return minLength == int.MaxValue ? string.Empty : input.Substring(minStart, minLength);
    }
}
