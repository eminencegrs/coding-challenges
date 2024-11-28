namespace LeetCode.Challenges.Problems01xx.N_0104_MaximumDepthOfBinaryTree;

public static class Solution
{
    public static int MaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(MaxDepth(root.Left), MaxDepth(root.Right)) + 1;
    }
}
