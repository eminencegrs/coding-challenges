namespace LeetCode.Challenges.MinimumSwapsToGroupAllOnesTogether;

// Please, pay attention:
// The input array is not circular!
public static class SlidingWindowSolution
{
    public static int MinSwaps(int[] nums)
    {
        var total = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            total += nums[i];
        }

        if (total is 0 or 1)
        {
            return 0;
        }

        var start = 0;
        var end = 0;

        var windowMax = 0;
        var currentWindow = 0;

        while (end < nums.Length)
        {
            currentWindow += nums[end];
            if (end - start + 1 == total)
            {
                windowMax = Math.Max(windowMax, currentWindow);
                if (nums[start] == 1)
                {
                    currentWindow--;
                }

                start++;
            }

            end++;
        }

        return total - windowMax;
    }
}
