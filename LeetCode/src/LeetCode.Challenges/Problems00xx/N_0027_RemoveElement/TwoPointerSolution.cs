namespace LeetCode.Challenges.Problems00xx.N_0027_RemoveElement;

public static class TwoPointerSolution
{
    public static int RemoveElement(int[] nums, int val)
    {
        ArgumentNullException.ThrowIfNull(nums);

        if (nums.Length == 0)
        {
            return 0;
        }

        var leftPointer = 0;
        var rightPointer = nums.Length - 1;

        while (leftPointer <= rightPointer)
        {
            if (nums[leftPointer] == val)
            {
                (nums[leftPointer], nums[rightPointer]) = (nums[rightPointer], nums[leftPointer]);
                rightPointer--;
            }
            else
            {
                leftPointer++;
            }
        }

        return leftPointer;
    }
}
