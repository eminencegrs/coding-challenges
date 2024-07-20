namespace LeetCode.Challenges.ThreeSumClosest;

public static class Solution
{
    public static int GetResult(int[] nums, int target)
    {
        Array.Sort(nums);
        int length = nums.Length;
        int closestSum = short.MaxValue;

        for (int i = length - 1; i >= 2; i--)
        {
            int leftPointer = 0;
            int rightPointer = i - 1;

            while (leftPointer < rightPointer)
            {
                int currentSum = nums[leftPointer] + nums[rightPointer] + nums[i];

                if (Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                {
                    closestSum = currentSum;
                }

                if (currentSum < target)
                {
                    leftPointer++;
                }
                else if (currentSum > target)
                {
                    rightPointer--;
                }
                else
                {
                    return target;
                }
            }
        }

        return closestSum;
    }
}
