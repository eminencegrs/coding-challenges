using System.Text;

namespace LeetCode.Challenges.Problems21xx.N_2109_AddingSpacesToString;

public static class BruteForceSolution
{
    public static string AddSpaces(string input, int[] spaces)
    {
        var sb = new StringBuilder();
        var pointer = 0;
        foreach (var space in spaces)
        {
            while (pointer < space)
            {
                sb.Append(input[pointer]);
                pointer++;
            }

            sb.Append(' ');
        }

        while (pointer < input.Length)
        {
            sb.Append(input[pointer]);
            pointer++;
        }

        return sb.ToString();
    }
}
