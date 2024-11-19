using System.Collections.ObjectModel;

namespace LeetCode.Challenges.Problems00xx.N_0013_RomanToInteger;

public static class Solution
{
    public static int RomanToInt(string number)
    {
        var result = 0;
        for (var i = 0; i < number.Length; i++)
        {
            var current = RomanToIntMap[number[i]];
            if (i == 0)
            {
                result += current;
                continue;
            }

            var previous = RomanToIntMap[number[i - 1]];
            if (previous < current)
            {
                result -= 2 * previous;
            }

            result += current;
        }

        return result;
    }

    private static readonly ReadOnlyDictionary<char, int> RomanToIntMap = new(
        new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        });
}
