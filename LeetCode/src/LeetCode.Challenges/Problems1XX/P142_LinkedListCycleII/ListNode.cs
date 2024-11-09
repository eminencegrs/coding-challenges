using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems1XX.P142_LinkedListCycleII;

[ExcludeFromCodeCoverage]
public class ListNode(int x)
{
    public int Value { get; set; } = x;
    public ListNode? Next { get; set; } = null;
}
