namespace LeetCode.Challenges.ValidParentheses;

public class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '{' or '[')
            {
                stack.Push(c);
            }
            else if (stack.Count == 0 || !this.IsMatchingPair(stack.Pop(), c))
            {
                return false;
            }
        }

        return stack.Count == 0;
    }

    private bool IsMatchingPair(char opening, char closing)
    {
        return
            (opening == '(' && closing == ')') ||
            (opening == '{' && closing == '}') ||
            (opening == '[' && closing == ']');
    }
}
