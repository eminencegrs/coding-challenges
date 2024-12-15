namespace DailyCodingProblem.Challenges.Y2024.M12.Day11;

public static class DfsSolution
{
    public static TreeNode? PruneTree(TreeNode? root)
    {
        return PruneTreeInternally(root);
    }

    private static TreeNode? PruneTreeInternally(TreeNode? node)
    {
        if (node == null)
        {
            return null;
        }

        node.Left = PruneTreeInternally(node.Left);
        node.Right = PruneTreeInternally(node.Right);

        if (node.Left == null && node.Right == null && node.Value == 0)
        {
            return null;
        }

        return node;
    }
}
