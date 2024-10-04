namespace LeetCode.Challenges.ReverseSubstringsBetweenParentheses;

// Time Complexity: O(n^2) - in the worst case.
public class BruteForceSolution
{
    // The input string is assumed to contain balanced parentheses.
    public string Reverse(string input)
    {
        var stack = new Stack<char>();

        foreach (var character in input)
        {
            if (character is ')')
            {
                var part = new List<char>();
                while (stack.Count > 0 && stack.Peek() is not '(')
                {
                    part.Add(stack.Pop());
                }

                stack.Pop();

                part.ForEach(x => stack.Push(x));
            }
            else
            {
                stack.Push(character);
            }
        }

        var res = stack.Reverse();
        return string.Join("", res);
    }
}
