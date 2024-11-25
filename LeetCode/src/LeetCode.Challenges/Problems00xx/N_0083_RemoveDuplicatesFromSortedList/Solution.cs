namespace LeetCode.Challenges.Problems00xx.N_0083_RemoveDuplicatesFromSortedList;

public static class Solution
{
    public static ListNode? DeleteDuplicates(ListNode? head)
    {
        if (head?.Next == null)
        {
            return head;
        }

        var previous = head;
        var current = head.Next;
        while (current != null)
        {
            if (current.Value == previous.Value)
            {
                previous.Next = current.Next;
            }
            else
            {
                previous = current;
            }

            current = current.Next;
        }

        return head;
    }
}
