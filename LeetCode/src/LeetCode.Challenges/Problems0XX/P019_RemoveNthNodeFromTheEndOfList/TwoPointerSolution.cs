namespace LeetCode.Challenges.Problems0XX.P019_RemoveNthNodeFromTheEndOfList;

// Time Complexity: O(n).
// Space Complexity: O(1).
public static class TwoPointerSolution
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // For example, we need to remove the 2nd node from the end of this list:
        // 1 --> 2 --> 3 --> 4 --> 5 --> null

        ListNode dummy = new ListNode(default, head);
        ListNode left = dummy;
        ListNode? right = head;

        // dummy --> 1 --> 2 --> 3 --> 4 --> 5 --> null
        //   ^       ^
        // (left)    ^
        //        (right)

        // Find where the right pointer should point to.
        while (n > 0 && right != null)
        {
            right = right.Next;
            n--;
        }

        // The 1st iteration, n is 2 (n > 0 && right IS NOT null):
        // dummy --> 1 --> 2 --> 3 --> 4 --> 5 --> null
        //   ^             ^
        // (left)          ^
        //              (right)

        // The 2nd iteration, n is 1 (n > 0 && right IS NOT null):
        // dummy --> 1 --> 2 --> 3 --> 4 --> 5 --> null
        //   ^                   ^
        // (left)                ^
        //                    (right)

        // The loop stops processing it because n is 0.
        // Now, we have the following picture:
        // dummy --> 1 --> 2 --> 3 --> 4 --> 5 --> null
        //   ^                   ^
        // (left)                ^
        //                    (right)

        // Move both pointers forward until the right one is null.
        // When the right pointer points to null, the left one points to the node before the one that should be removed.
        while (right != null)
        {
            left = left.Next!;
            right = right.Next;
        }

        // The 1st iteration (before the iteration, right IS NOT null).
        // Thus, we can move the pointers.
        // dummy --> 1 --> 2 --> 3 --> 4 --> 5 --> null
        //           ^                 ^
        //        (left)               ^
        //                          (right)

        // The 2nd iteration (before the iteration, right IS NOT null).
        // Thus, we can move the pointers.
        // dummy --> 1 --> 2 --> 3 --> 4 --> 5 --> null
        //                 ^                 ^
        //              (left)               ^
        //                                (right)

        // The 3rd iteration (before the iteration, right IS NOT null).
        // Thus, we can move the pointers.
        // dummy --> 1 --> 2 --> 3 --> 4 --> 5 --> null
        //                       ^                  ^
        //                    (left)                ^
        //                                       (right)

        // The loop stops processing it because right IS null.
        // So, 'left.next' exactly points to the node to be removed.

        // Let's update the pointers.
        // Before:
        // 1 --> 2 --> 3 --> 4 --> 5 --> null
        left.Next = left.Next?.Next;

        // After:
        // 1 --> 2 --> 3 --> 5 --> null

        return dummy.Next!;
    }
}
