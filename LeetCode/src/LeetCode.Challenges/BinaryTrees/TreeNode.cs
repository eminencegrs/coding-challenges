using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.BinaryTrees;

[ExcludeFromCodeCoverage]
public class TreeNode
{
    public string Value { get; init; } = null!;
    public TreeNode? Left { get; init; }
    public TreeNode? Right { get; init; }
}
