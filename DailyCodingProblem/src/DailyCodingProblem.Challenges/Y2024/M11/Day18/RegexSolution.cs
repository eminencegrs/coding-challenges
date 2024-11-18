using System.Text.RegularExpressions;

namespace DailyCodingProblem.Challenges.Y2024.M11.Day18;

public static class RegexSolution
{
    public static bool CheckIfNumber(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        string pattern = @"^[-+]?(?:\d+\.?\d*|\.\d+)(?:[eE][-+]?\d+)?$";
        return Regex.IsMatch(input, pattern);
    }
}
