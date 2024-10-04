using System.Text;

namespace LeetCode.Challenges.ReverseSubstringsBetweenParentheses;

// Time Complexity: O(n).
public class OptimizedSolution
{
    // The input string is assumed to contain balanced parentheses.
    public string Reverse(string input)
    {
        var characters = input.ToCharArray();
        var inputLength = characters.Length;
        var parenthesesPairs = new Dictionary<int, int>();
        var stack = new Stack<int>();
        var result = new StringBuilder();

        // Preprocessing.
        for (var i = 0; i < inputLength; i++)
        {
            // If it's opening - add to the stack & move forward.
            if (characters[i] == '(')
            {
                stack.Push(i);
            }
            // If it's closing - pop its pair from the stack & add to the dictionary.
            else if (characters[i] == ')')
            {
                var right = stack.Pop();
                parenthesesPairs[i] = right;
                parenthesesPairs[right] = i;
            }
        }

        // The initial direction is from left to right.
        var direction = 1;
        var index = 0;
        while (index < inputLength)
        {
            if (characters[index] is '(' or ')')
            {
                index = parenthesesPairs[index];
                direction = -direction;
            }
            else
            {
                result.Append(characters[index]);
            }

            index += direction;
        }

        return result.ToString();
    }
}
