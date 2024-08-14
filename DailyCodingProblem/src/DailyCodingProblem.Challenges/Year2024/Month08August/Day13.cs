namespace DailyCodingProblem.Challenges.Year2024.Month08August;

// This problem was asked by Facebook.
// Given a string of round, curly, and square open and closing brackets.
// Return whether the brackets are balanced (well-formed).
// 
// For example:
//  - given the string "([])[]({})", it should return true.
//  - given the string "([)]" or "((()", it should return false.
public static class Day13
{
    public static bool CheckIfBalanced(string brackets)
    {
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
