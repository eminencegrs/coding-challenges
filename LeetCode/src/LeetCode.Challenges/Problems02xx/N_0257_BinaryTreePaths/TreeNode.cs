using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems02xx.N_0257_BinaryTreePaths;

[ExcludeFromCodeCoverage]
public record class TreeNode
{
    public int Value { get; init; }
    public TreeNode? Left { get; init; }
    public TreeNode? Right { get; init; }
}
