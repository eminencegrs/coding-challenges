namespace LeetCode.Challenges.Problems25xx.P2560_HouseRobberIV;

public static class Solution
{
    public static int MinCapability(int[] nums, int k)
    {
        var low = nums.Min();
        var high = nums.Max();

        while (low < high)
        {
            var mid = (low + high) / 2;
            if (CanRob(mid))
            {
                high = mid;
            }
            else
            {
                low = mid + 1;
            }
        }

        return low;

        bool CanRob(int x)
        {
            var robCount = 0;
            var i = 0;
            while (i < nums.Length)
            {
                if (nums[i] <= x)
                {
                    robCount++;
                    i += 2;
                }
                else
                {
                    i += 1;
                }

                if (robCount >= k)
                {
                    return true;
                }
            }

            return robCount >= k;
        }
    }
}

    