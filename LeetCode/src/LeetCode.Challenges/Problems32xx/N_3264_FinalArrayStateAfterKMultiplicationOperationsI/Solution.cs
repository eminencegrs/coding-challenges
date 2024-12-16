namespace LeetCode.Challenges.Problems32xx.N_3264_FinalArrayStateAfterKMultiplicationOperationsI;

public static class Solution
{
    public static int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        // Min-heap to store (index, value) and prioritize by value, then index.
        PriorityQueue<(int Index, int Value), (int Value, int Index)> minHeap = new();

        // Populate the min-heap with initial array elements.
        for (var i = 0; i < nums.Length; i++)
        {
            minHeap.Enqueue((i, nums[i]), (nums[i], i));
        }

        // Perform 'k' operations.
        for (var i = 0; i < k; i++)
        {
            // Extract the smallest element (first occurrence of the smallest value)
            var (index, value) = minHeap.Dequeue();

            // Update the value by multiplying with the multiplier.
            nums[index] = value * multiplier;

            // Re-enqueue the updated value.
            minHeap.Enqueue((index, nums[index]), (nums[index], index));
        }

        return nums;
    }
}
