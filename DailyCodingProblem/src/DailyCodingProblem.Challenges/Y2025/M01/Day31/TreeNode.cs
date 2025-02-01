using System.Diagnostics.CodeAnalysis;

namespace DailyCodingProblem.Challenges.Y2025.M01.Day31;

[ExcludeFromCodeCoverage]
public class TreeNode(int value)
{
    public int Value { get; set; } = value;
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
