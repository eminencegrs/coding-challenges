namespace LeetCode.Challenges.ContainerWithMostWater;

// Time Complexity:
// The loop continues until left is no longer less than right.
// Since left starts from `0` and right starts from `heights.Length - 1`,
// and one of them is moved closer to the other in each iteration,
// the loop will execute at most `n - 1` times where `n` is the length of the `heights` array.
// The time complexity of the algorithm is O(n).
// 
// Space Complexity of the algorithm is O(1).
public static class Solution
{
    public static int GetMaxArea(int[] heights)
    {
        var leftPointer = 0;
        var rightPointer = heights.Length - 1;
        var maxArea = int.MinValue;
        while (leftPointer < rightPointer)
        {
            var leftEdgeHeight = heights[leftPointer];
            var rightEdgeHeight = heights[rightPointer];
            var minEdgeHeight = Math.Min(leftEdgeHeight, rightEdgeHeight);
            var currentArea = minEdgeHeight * (rightPointer - leftPointer);
            if (maxArea < currentArea)
            {
                maxArea = currentArea;
            }

            if (leftEdgeHeight < rightEdgeHeight)
            {
                leftPointer++;
            }
            else
            {
                rightPointer--;
            }
        }

        return maxArea;
    }
}
