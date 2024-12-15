using System.Diagnostics.CodeAnalysis;

namespace DailyCodingProblem.Challenges.Y2024.M12.Day11;

[ExcludeFromCodeCoverage]
public class TreeNode(int value)
{
    public int Value { get; set; } = value;
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }
}
