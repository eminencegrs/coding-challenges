namespace LeetCode.Challenges.ReverseInteger;

public static class Solution
{
    public static int Reverse(int x)
    {
        int result = 0;

        while (x != 0)
        {
            int temp = x % 10;
            x /= 10;

            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && temp > 7))
            {
                return 0;
            }

            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && temp < -8))
            {
                return 0;
            }

            result = result * 10 + temp;
        }

        return result;
    }
}
