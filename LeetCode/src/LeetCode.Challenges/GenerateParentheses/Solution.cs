namespace LeetCode.Challenges.GenerateParentheses;

public class Solution
{
    private readonly List<string> result = [];

    public IList<string> GenerateParenthesis(int n)
    {
        this.Handle("", 0, 0, n);
        return this.result;
    }

    private void Handle(string str, int left, int right, int n)
    {
        if (left == right && left == n)
        {
            this.result.Add(str);
            return;
        }

        if (left < n)
        {
            this.Handle(str + "(", left + 1, right, n);
        }

        if (right < left)
        {
            this.Handle(str + ")", left, right + 1, n);
        }
    }
}
