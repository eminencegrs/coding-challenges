namespace LeetCode.Challenges.SearchInRotatedSortedArray;

// Binary search.
// Time Complexity: O(log(n))
public static class Solution
{
    public static int Search(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }

            // Check the left side.
            if (nums[left] <= nums[mid])
            {
                if (nums[left] > target || nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            // Check the right side.
            else
            {
                if (nums[right] < target || nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }

        return -1;
    }
}
