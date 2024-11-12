using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems0XX.P024_SwapNodesInPairs;

[ExcludeFromCodeCoverage]
public class ListNode(int value = default, ListNode? next = null)
{
    public int Value { get; set; } = value;
    public ListNode? Next { get; set; } = next;
}
