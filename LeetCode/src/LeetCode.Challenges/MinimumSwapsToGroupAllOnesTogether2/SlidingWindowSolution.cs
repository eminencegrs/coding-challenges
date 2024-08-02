namespace LeetCode.Challenges.MinimumSwapsToGroupAllOnesTogether2;

// Sliding Window Technique.
// Time Complexity: O(n)
public static class SlidingWindowSolution
{
    public static int MinSwaps(int[] nums)
    {
        var arraySize = nums.Length;

        // First of all, we need to calculate the total number of all 1's in the `nums` array.
        // A sliding window size will be the total number.
        var total = 0;
        for (var i = 0; i < arraySize; i++)
        {
            total += nums[i];
        }

        if (total is 0 or 1)
        {
            return 0;
        }

        var windowLeft = 0;
        var windowRight = 0;

        var windowMaxCount = 0;
        var windowCurrentCount = 0;

        // The number of all iterations is more than just an array size because the array is circular.
        while (windowRight < arraySize + total)
        {
            // Calculate the number of 1's in the current window.
            // `windowRight % arraySize` ensures that the index stays within the bounds of the array.
            windowCurrentCount += nums[windowRight % arraySize];

            // Check if we have reached the sliding window size.
            if (windowRight - windowLeft + 1 == total)
            {
                windowMaxCount = Math.Max(windowMaxCount, windowCurrentCount);

                // Before sliding the window, check if the first item is 1.
                if (nums[windowLeft % nums.Length] == 1)
                {
                    // If yes, the current counter must be decreased as the left boundary is going to be moved further.
                    windowCurrentCount--;
                }

                // Move the left boundary of the window.
                windowLeft++;
            }

            // Move the right boundary of the window.
            windowRight++;
        }

        // The number of swaps required is the number of 0’s in the subarray (sliding window).
        return total - windowMaxCount;
    }
}
