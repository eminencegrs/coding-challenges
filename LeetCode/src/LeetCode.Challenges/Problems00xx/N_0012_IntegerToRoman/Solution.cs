using System.Text;

namespace LeetCode.Challenges.Problems00xx.N_0012_IntegerToRoman;

// Time Complexity: O(n).
// Space Complexity: O(n).
public static class Solution
{
    public static string IntToRoman(int number)
    {
        var result = new StringBuilder();

        foreach (var kv in RomanToIntegerMap)
        {
            var count = number / kv.Value;
            if (count == 0)
            {
                continue;
            }

            result.Append(string.Concat(Enumerable.Repeat(kv.Key, count)));
            number %= kv.Value;
        }

        return result.ToString();
    }

    private static readonly Dictionary<string, int> RomanToIntegerMap = new()
    {
        { "M", 1000 },
        { "CM", 900 },
        { "D", 500 },
        { "CD", 400 },
        { "C", 100 },
        { "XC", 90 },
        { "L", 50 },
        { "XL", 40 },
        { "X", 10 },
        { "IX", 9 },
        { "V", 5 },
        { "IV", 4 },
        { "I", 1 }
    };
}
