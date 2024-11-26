using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems02xx.N_0297_SerializeAndDeserializeBinaryTree;

[ExcludeFromCodeCoverage]
public class TreeNode(int value)
{
    public int Value { get; set; } = value;
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
