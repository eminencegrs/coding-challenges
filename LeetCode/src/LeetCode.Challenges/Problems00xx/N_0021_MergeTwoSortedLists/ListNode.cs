using System.Diagnostics.CodeAnalysis;

namespace LeetCode.Challenges.Problems00xx.N_0021_MergeTwoSortedLists;

[ExcludeFromCodeCoverage]
public class ListNode(int value = default, ListNode? next = null)
{
    public int Value { get; set; } = value;

    public ListNode? Next { get; set; } = next;
}
