# Common Patterns & Approaches

## Sliding Window

It is a technique used to solve problems involving a subset of elements within an **array** or **sequence**.  
It is particularly useful when the goal is to find an optimal range or calculate a specific measurement 
within a subset of contiguous elements. The main idea is to maintain a "window" that slides across 
the array from the beginning to the end. This window can vary in size, depending on the problem:

 - **Fixed-Size Sliding Window:** Useful for problems that require processing or optimizing over a fixed number of contiguous elements.

 - **Variable-Size Sliding Window:** Useful for problems where the window can grow or shrink, often to meet a condition dynamically.

### Key Steps

 1. Initialize the window with the required starting elements (for fixed or variable sizes).
 2. Expand or shrink the window by moving its boundaries as needed.
 3. Track necessary metrics (like a sum, maximum, or minimum) while sliding the window.
 4. Slide the window forward: remove the influence of the outgoing element and add the influence of the incoming element at each step.

The sliding window approach is highly efficient, often achieving O(n) time complexity, 
since it avoids redundant calculations by reusing information from previous steps.

### Example Problem

Given an integer array and a number `k`, find the maximum sum of any contiguous subarray of length `k`.

For instance:

Input: `arr = [1, 3, 5, 2, 8, 1, 5]`, `k = 3`  
Output: `15 (from subarray [5, 2, 8])`  

**C# implementation**:

```csharp
public class SlidingWindowApproach
{
    public static int GetMaxSumSubarray(int[] arr, int k)
    {
        if (arr.Length < k)
        {
            throw new ArgumentException("Array length must be at least k.");
        }

        int maxSum = 0;
        int currentSum = 0;

        // Calculate the sum of the first window.
        for (int i = 0; i < k; i++)
        {
            currentSum += arr[i];
        }

        maxSum = currentSum;

        // Slide the window across the array.
        for (int i = k; i < arr.Length; i++)
        {
            // Shift the window to the right:
            // 1. Subtract the element that is leaving the window: arr[i - k];
            // 2. Add the element that is entering the window: arr[i].
            currentSum += arr[i] - arr[i - k];
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}
```
