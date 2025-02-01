namespace DailyCodingProblem.Challenges.Y2025.M02.Day01;

public class Solution
{
    public static void Rotate(int[] array, int k, string direction)
    {
        var n = nums.Length;
        if (n == 0)
        {
            return;
        }

        // Handle cases where k > n.
        k = k % n;

        if (direction == "left")
        {
            // Left rotation is equivalent to right rotation by (n - k).
            k = n - k;
        }

        // Perform the three-step reversal.
        Reverse(nums, 0, n - 1);    // Step 1: Reverse entire array.
        Reverse(nums, 0, k - 1);    // Step 2: Reverse first k elements.
        Reverse(nums, k, n - 1);    // Step 3: Reverse remaining elements.
    }

    private void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            var temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
