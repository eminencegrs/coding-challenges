using System.Text;

namespace LeetCode.Challenges.ReverseSubstringsBetweenParentheses;

// Time Complexity: O(n).
public class OptimizedSolution
{
    public string Reverse(string s)
    {
        var inputChars = s.ToCharArray();
        var inputLength = inputChars.Length;
        var parenthesesPairs = new Dictionary<int, int>();
        var stack = new Stack<int>();
        var result = new StringBuilder();

        // Preprocessing.
        for (var i = 0; i < inputLength; i++)
        {
            // If it's opening - add to the stack & move forward.
            if (inputChars[i] == '(')
            {
                stack.Push(i);
            }
            // If it's closing - pop its pair from the stack & add to the dictionary.
            else if (inputChars[i] == ')')
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
            if (inputChars[index] is '(' or ')')
            {
                index = parenthesesPairs[index];
                direction = -direction;
            }
            else
            {
                result.Append(inputChars[index]);
            }

            index += direction;
        }

        return result.ToString();
    }
}
