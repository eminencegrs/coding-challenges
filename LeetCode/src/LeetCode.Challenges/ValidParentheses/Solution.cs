namespace LeetCode.Challenges.ValidParentheses;

public static class Solution
{
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '{' or '[')
            {
                stack.Push(c);
            }
            else if (stack.Count == 0 || !IsMatchingPair(stack.Pop(), c))
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

    private static bool IsMatchingPair(char opening, char closing)
    {
        return
            (opening == '(' && closing == ')') ||
            (opening == '{' && closing == '}') ||
            (opening == '[' && closing == ']');
    }
}
