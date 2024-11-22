using System.Text;

namespace LeetCode.Challenges.Problems00xx.N_0067_AddBinary;

public static class Solution
{
    public static string AddBinary(string a, string b)
    {
        ArgumentException.ThrowIfNullOrEmpty(a);
        ArgumentException.ThrowIfNullOrEmpty(b);

        var result = new StringBuilder();
        var i = a.Length - 1;
        var j = b.Length - 1;
        var carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            result.Insert(0, sum % 2);
            carry = sum / 2; 
        }

        return result.ToString();
    }
}
