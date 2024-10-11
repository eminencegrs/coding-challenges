namespace DailyCodingProblem.Challenges.Y2024.M10;

// This problem was asked by Google.
// Given a string of parentheses, write a function to compute the minimum number of parentheses
// to be removed to make the string valid (i.e. each open parenthesis is eventually closed).
// For example:
//  - Given the string "()())()", you should return 1.
//  - Given the string ")(", you should return 2, since we must remove all of them.

// Time Complexity: O(n).
public static class Day11Task
{
    public static int GetNumberOfParenthesesToRemove(string parentheses)
    {
        var stack = new Stack<char>();

        foreach (var c in parentheses)
        {
            if (c is '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count > 0 && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
        }

        return stack.Count;
    }
}
