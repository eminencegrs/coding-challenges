namespace LeetCode.Challenges.Problems01xx.P0142_LinkedListCycleII;

public static class FloydCycleDetection
{
    public static ListNode? DetectCycle(ListNode? listHead)
    {
        return listHead == null
            ? null
            : TryGetCycleTail(listHead, out var cycleTail)
                ? GetCycleHead(listHead, cycleTail)
                : null;
    }

    private static bool TryGetCycleTail(ListNode head, out ListNode? cycleTail)
    {
        var slow = head;
        var fast = head;

        while (slow?.Next != null && fast?.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow != fast)
            {
                continue;
            }

            cycleTail = slow;
            return true;
        }

        cycleTail = null;
        return false;
    }

    private static ListNode? GetCycleHead(ListNode head, ListNode? cycleTail)
    {
        var fast = head;
        var slow = cycleTail;
        while (fast != slow)
        {
            fast = fast?.Next;
            slow = slow?.Next;
        }

        return fast;
    }
}
