using System.Diagnostics.CodeAnalysis;

namespace DailyCodingProblem.Challenges.Y2024.M11.Day30;

[ExcludeFromCodeCoverage]
public record class TreeNode
{
    public int Value { get; init; }
    public TreeNode? Left { get; init; }
    public TreeNode? Right { get; init; }
}
