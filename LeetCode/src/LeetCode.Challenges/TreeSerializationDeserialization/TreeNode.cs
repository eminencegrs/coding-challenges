using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.TreeSerializationDeserialization;

[ExcludeFromCodeCoverage]
public class TreeNode
{
    public int Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
