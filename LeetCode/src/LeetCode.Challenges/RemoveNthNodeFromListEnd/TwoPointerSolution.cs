namespace LeetCode.Challenges.RemoveNthNodeFromListEnd;

// Time Complexity: O(n).
// Space Complexity: O(1).
public class TwoPointerSolution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode dummy = new ListNode(default, head);
        ListNode slow = dummy;
        ListNode? fast = head;

        while (n > 0 && fast != null)
        {
            fast = fast.Next;
            n--;
        }

        while (fast != null)
        {
            slow = slow.Next!;
            fast = fast.Next;
        }

        slow.Next = slow.Next?.Next;

        return dummy.Next!;
    }
}
