namespace LeetCode.Challenges.Problems01xx.P0141_LinkedListCycle;

public static class SlowFastPointerApproach
{
    public static bool HasCycle(ListNode? head)
    {
        if (head == null)
        {
            return false;
        }

        var slow = head;
        var fast = head;

        while (slow?.Next != null && fast?.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }
}
