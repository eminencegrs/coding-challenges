namespace DailyCodingProblem.Challenges.Y2024.M11.Day12;

public class TreeNode(int value)
{
    public int Value { get; set; } = value;
    public TreeNode? Left { get; init; }
    public TreeNode? Right { get; init; }
}
