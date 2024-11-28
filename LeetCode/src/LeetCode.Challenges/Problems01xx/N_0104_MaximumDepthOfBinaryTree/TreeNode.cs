using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems01xx.N_0104_MaximumDepthOfBinaryTree;

[ExcludeFromCodeCoverage]
public class TreeNode(int value = default, TreeNode? left = null, TreeNode? right = null)
{
    public int Value { get; set; } = value;
    public TreeNode? Left { get; set; } = left;
    public TreeNode? Right { get; set; } = right;
}
