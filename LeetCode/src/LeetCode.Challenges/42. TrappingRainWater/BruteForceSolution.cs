// ReSharper disable once CheckNamespace
namespace LeetCode.Challenges.TrappingRainWater;

public static class BruteForceSolution
{
    public static int GetResult(int[] height)
    {
        var waterTrapped = 0;

        for (var i = 1; i < height.Length - 1; i++)
        {
            var leftMax = height[i];
            for (var j = 0; j < i; j++)
            {
                leftMax = Math.Max(leftMax, height[j]);
            }

            var rightMax = height[i];
            for (var j = i + 1; j < height.Length; j++)
            {
                rightMax = Math.Max(rightMax, height[j]);
            }

            waterTrapped += Math.Min(leftMax, rightMax) - height[i];
        }

        return waterTrapped;
    }
}
