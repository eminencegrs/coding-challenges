namespace DailyCodingProblem.Challenges.Y2024.M11.Day30;

public static class Solution
{
    public static int FindMinPathSum(TreeNode? node)
    {
        if (node == null)
        {
            return 0;
        }

        return Math.Min(FindMinPathSum(node.Left), FindMinPathSum(node.Right)) + node.Value;
    }
}
