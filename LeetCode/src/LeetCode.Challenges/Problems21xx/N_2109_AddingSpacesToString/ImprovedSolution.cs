using System.Text;

namespace LeetCode.Challenges.Problems21xx.N_2109_AddingSpacesToString;

public static class ImprovedSolution
{
    public static string AddSpaces(string input, int[] spaces)
    {
        var sb = new StringBuilder();
        var charPointer = 0;
        var spacePointer = 0;

        while (charPointer < input.Length)
        {
            if (spacePointer < spaces.Length && charPointer == spaces[spacePointer])
            {
                sb.Append(' ');
                spacePointer++;
            }

            sb.Append(input[charPointer]);
            charPointer++;
        }

        return sb.ToString();
    }
}
