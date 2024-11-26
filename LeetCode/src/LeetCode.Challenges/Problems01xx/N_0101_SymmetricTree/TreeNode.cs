using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems01xx.N_0101_SymmetricTree;

[ExcludeFromCodeCoverage]
public class TreeNode(int value = default, TreeNode? left = null, TreeNode? right = null)
{
    public int Value { get; init; } = value;
    public TreeNode? Left { get; init; } = left;
    public TreeNode? Right { get; init; } = right;
}
