using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems01xx.N_0142_LinkedListCycleII;

[ExcludeFromCodeCoverage]
public class ListNode(int x)
{
    public int Value { get; set; } = x;
    public ListNode? Next { get; set; } = null;
}
