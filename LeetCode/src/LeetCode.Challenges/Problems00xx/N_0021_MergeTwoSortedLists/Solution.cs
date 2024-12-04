namespace LeetCode.Challenges.Problems00xx.N_0021_MergeTwoSortedLists;

public static class Solution
{
    public static ListNode? MergeTwoLists(ListNode? first, ListNode? second)
    {
        if (first == null)
        {
            return second;
        }

        if (second == null)
        {
            return first;
        }

        var dummy = new ListNode();
        var tail = dummy;

        while (first != null && second != null)
        {
            if (first.Value < second.Value)
            {
                tail.Next = first;
                first = first.Next;
            }
            else
            {
                tail.Next = second;
                second = second.Next;
            }

            tail = tail.Next;
        }

        if (first != null)
        {
            tail.Next = first;
        }
        else if (second != null)
        {
            tail.Next = second;
        }

        return dummy.Next;
    }
}
