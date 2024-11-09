namespace LeetCode.Challenges.Problems1XX.P100_SameTree;

public static class Solution
{
    public static bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if ((p == null && q != null) || (p != null && q == null))
        {
            return false;
        }

        if (p?.Value != q?.Value)
        {
            return false;
        }

        if (!IsSameTree(p?.Left, q?.Left))
        {
            return false;
        }

        if (!IsSameTree(p?.Right, q?.Right))
        {
            return false;
        }

        return true;
    }
}
