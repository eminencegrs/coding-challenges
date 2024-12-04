namespace LeetCode.Challenges.Problems00xx.N_0026_RemoveDuplicatesFromSortedArray;

// Constraints:
// 1 <= nums.length <= 3 * 10^4
// -100 <= nums[i] <= 100
// 'nums' is sorted in non-decreasing order

// Time Complexity: O(n).
// Space Complexity: O(1).
public static class TwoPointerSolution
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
        {
            return 1;
        }

        var leftPointer = 1;
        var rightPointer = 1;

        while (rightPointer < nums.Length)
        {
            if (nums[rightPointer] == nums[rightPointer - 1])
            {
                rightPointer++;
                continue;
            }

            nums[leftPointer] = nums[rightPointer];
            leftPointer++;
            rightPointer++;
        }

        return leftPointer;
    }
}
