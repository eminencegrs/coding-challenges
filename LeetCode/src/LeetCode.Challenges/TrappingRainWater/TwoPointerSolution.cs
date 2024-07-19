namespace LeetCode.Challenges.TrappingRainWater;

public static class TwoPointerSolution
{
    public static int GetResult(int[] height)
    {
        var waterTrapped = 0;

        var leftPointer = 0;
        var rightPointer = height.Length - 1;

        var leftMax = height[leftPointer];
        var rightMax = height[rightPointer];

        while (leftPointer < rightPointer)
        {
            if (leftMax < rightMax)
            {
                leftPointer++;
                leftMax = Math.Max(leftMax, height[leftPointer]);
                waterTrapped += leftMax - height[leftPointer];
            }
            else
            {
                rightPointer--;
                rightMax = Math.Max(rightMax, height[rightPointer]);
                waterTrapped += rightMax - height[rightPointer];
            }
        }

        return waterTrapped;
    }
}
