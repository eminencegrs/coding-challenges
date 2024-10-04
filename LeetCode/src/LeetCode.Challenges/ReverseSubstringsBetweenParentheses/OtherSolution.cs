using System.Text;

namespace LeetCode.Challenges.ReverseSubstringsBetweenParentheses;

public class OtherSolution
{
    public string Reverse(string input)
    {
        var stack = new Stack<int>();
        var characters = input.ToCharArray();

        // First pass: find matching parentheses.
        for (var i = 0; i < characters.Length; i++)
        {
            if (characters[i] == '(')
            {
                stack.Push(i);
            }
            else if (characters[i] == ')')
            {
                var openIndex = stack.Pop();
                this.ReverseInternal(characters, openIndex + 1, i - 1);
            }
        }

        // Second pass: build the result string without parentheses.
        var result = new StringBuilder();
        foreach (var c in characters)
        {
            if (c != '(' && c != ')')
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }

    private void ReverseInternal(char[] chars, int left, int right)
    {
        while (left < right)
        {
            (chars[left], chars[right]) = (chars[right], chars[left]);
            left++;
            right--;
        }
    }
}
