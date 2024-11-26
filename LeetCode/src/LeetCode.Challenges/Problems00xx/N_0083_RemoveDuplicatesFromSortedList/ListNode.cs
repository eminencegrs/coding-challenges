using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems00xx.N_0083_RemoveDuplicatesFromSortedList;

[ExcludeFromCodeCoverage]
public class ListNode(int value = 0, ListNode? next = null)
{
    public int Value { get; set; } = value;
    public ListNode? Next { get; set; } = next;
}
