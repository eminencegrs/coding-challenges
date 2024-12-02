using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems00xx.N_0094_BinaryTreeInorderTraversal;

[ExcludeFromCodeCoverage]
public class TreeNode(int value = default, TreeNode? left = null, TreeNode? right = null)
{
    public int Value { get; set; } = value;
    public TreeNode? Left { get; set; } = left;
    public TreeNode? Right { get; set; } = right;
}
