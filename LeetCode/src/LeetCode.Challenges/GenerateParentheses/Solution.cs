using System.Text;

namespace LeetCode.Challenges.GenerateParentheses;

public class Solution
{
    private readonly List<string> results = [];

    public IList<string> GenerateParenthesis(int n)
    {
        this.Handle("", 0, 0, n);
        return this.results;
    }

    private void Handle(string parenthesis, int left, int right, int n)
    {
        // The base case is when the number of opening parenthesis (`left`) equals
        // the number of closing parenthesis (`right`).
        // It means, a complete valid combination of parenthesis is formed.
        // In this case, the `parenthesis` string is added to the `results` list.
        if (left == right && left == n)
        {
            this.results.Add(parenthesis);
            return;
        }

        // If the number of opening parenthesis (`left`) is less than `n` (the  number of parenthesis pairs),
        // it recursively calls itself by appending an opening parenthesis to the `parenthesis` string
        // and increments the number of opening parenthesis: `left`.
        if (left < n)
        {
            this.Handle($"{parenthesis}(", left + 1, right, n);
        }

        // If the number of closing parenthesis (`right`) is less than the number of opening parenthesis (`left`),
        // it recursively calls itself by appending a closing parenthesis to the `parenthesis` string
        // and increments the number of closing parenthesis: `right`.
        if (right < left)
        {
            this.Handle($"{parenthesis})", left, right + 1, n);
        }
    }
}
