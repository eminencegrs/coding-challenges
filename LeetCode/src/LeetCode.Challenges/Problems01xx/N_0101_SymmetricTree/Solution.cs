namespace LeetCode.Challenges.Problems01xx.N_0101_SymmetricTree;

public static class Solution
{
    public static bool IsSymmetric(TreeNode? root)
    {
        return root == null || Verify(root.Left, root.Right);
    }

    private static bool Verify(TreeNode? left, TreeNode? right)
    {
        if (left == null && right == null)
        {
            return true;
        }

        if (left == null || right == null || left.Value != right.Value)
        {
            return false;
        }

        return Verify(left.Left, right.Right) && Verify(left.Right, right.Left);
    }
}
