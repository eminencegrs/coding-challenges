namespace DailyCodingProblem.Challenges.Y2024.M12.Day24;

public static class Solution
{
    public static char? GetFirstRecurringChar(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return null;
        }

        var temp = new HashSet<char>();
        foreach (var ch in input)
        {
            if (!temp.Add(ch))
            {
                return ch;
            }
        }

        return null;
    }
}
