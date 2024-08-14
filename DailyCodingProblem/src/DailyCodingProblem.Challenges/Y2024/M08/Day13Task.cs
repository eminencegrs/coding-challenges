namespace DailyCodingProblem.Challenges.Y2024.M08;

// This problem was asked by Facebook.
// Given a string of round, curly, and square open and closing brackets.
// Return whether the brackets are balanced (well-formed).
// 
// For example:
//  -- given the string "([])[]({})", it should return true.
//  -- given the string "([)]" or "((()", it should return false.
//
// Time Complexity:
//  -- O(1) - for the best case. Since the function checks the length at the start,
// if the string length is odd, it immediately returns false without entering the loop.
//  -- O(n) - for the worst and average cases.
public static class Day13Task
{
    public static bool CheckIfBalanced(string brackets)
    {
        // This is based on the assumption that a balanced string must have an even number of characters
        // (since each opening bracket requires a corresponding closing bracket).
        if (brackets.Length % 2 != 0)
        {
            return false;
        }

        var stack = new Stack<char>();
        foreach (var bracket in brackets)
        {
            if (CheckIfOpening(bracket))
            {
                stack.Push(bracket);
            }

            if (!CheckIfClosing(bracket))
            {
                continue;
            }

            if (stack.Count == 0)
            {
                return false;
            }

            if (!CheckIfPair(stack.Pop(), bracket))
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

    private static bool CheckIfOpening(char bracket) => bracket is '(' or '{' or '[';

    private static bool CheckIfClosing(char bracket) => bracket is ')' or '}' or ']';

    private static bool CheckIfPair(char opening, char closing) =>
        (opening, closing) switch
        {
            ('(', ')') => true,
            ('{', '}') => true,
            ('[', ']') => true,
            _ => false
        };
}
