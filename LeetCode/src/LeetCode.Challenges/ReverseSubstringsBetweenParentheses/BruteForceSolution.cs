using System.Text;

namespace LeetCode.Challenges.ReverseSubstringsBetweenParentheses;

// This is not a linear algorithm.
// Time Complexity: O(n^2) - in the worst case.
public class BruteForceSolution
{
    public string Reverse(string s)
    {
        throw new NotImplementedException();
        
        var chars = s.ToCharArray();
        var builder = new StringBuilder();
        var stack = new Stack<char>();

        for (var i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ')')
            {
                var part = new Stack<char>();
                for (var j = 0; j < stack.Count; j++)
                {
                    part.Push(stack.Pop());
                }

                for (var j = 0; j < part.Count; j++)
                {
                    stack.Push(part.Pop());
                }
            }
            else
            {
                stack.Push(chars[i]);
            }
        }

        for (var i = 0; i < stack.Count; i++)
        {
            builder.Append(stack.Pop());
        }

        return builder.ToString();
    }
}
