using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems00xx.P0019_RemoveNthNodeFromTheEndOfList;

[ExcludeFromCodeCoverage]
public class ListNode(int val = default, ListNode? next = null)
{
    public int Value { get; set; } = val;
    public ListNode? Next { get; set; } = next;
}
