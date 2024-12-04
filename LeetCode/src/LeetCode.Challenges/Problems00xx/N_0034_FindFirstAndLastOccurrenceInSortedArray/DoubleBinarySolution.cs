namespace LeetCode.Challenges.Problems00xx.N_0034_FindFirstAndLastOccurrenceInSortedArray;

public static class DoubleBinarySolution
{
    public static int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return [-1, -1];
        }

        return [BinarySearch(nums, target, Position.First), BinarySearch(nums, target, Position.Last)];
    }

    private static int BinarySearch(int[] nums, int target, Position position)
    {
        var left = 0;
        var right = nums.Length - 1;

        var result = -1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (target > nums[mid])
            {
                left = mid + 1;
            }
            else if (target < nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                result = mid;
                if (position == Position.First)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
        }

        return result;
    }

    private enum Position
    {
        First = 0,
        Last
    }
}
