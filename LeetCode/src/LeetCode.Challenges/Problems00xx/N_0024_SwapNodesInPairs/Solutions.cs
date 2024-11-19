namespace LeetCode.Challenges.Problems00xx.N_0024_SwapNodesInPairs;

public static class Solution
{
    public static ListNode? SwapPairs(ListNode? head)
    {
        // Example:
        //            Input: 1 --> 2 --> 3 --> 4
        //  Expected Result: 2 --> 1 --> 4 --> 3

        // Let's introduce a dummy node that points to the head:
        var dummy = new ListNode(default, head);

        // [dummy,next is [1]] --> [1,next is [2]] --> [2,next is [3]] --> [3,next is [4]] --> [4,next is null]

        // Let's create a few helper pointers:
        var (prev, current) = (dummy, next: dummy.Next);

        // [dummy,next is [1]] --> [1,next is [2]] --> [2,next is [3]] --> [3,next is [4]] --> [4,next is null]
        //   ^                      ^
        // prev                  current

        // Because we need to swap every two adjacent nodes (?).
        while (current != null && current.Next != null)
        {
            // STEP 1: Save pointers.
            var nextPair = current.Next.Next;
            var second = current.Next;

            // [dummy,next is [1]] --> [1,next is [2]] --> [2,next is [3]] --> [3,next is [4]] --> [4,next is null]
            //   ^                      ^                   ^                   ^
            // prev                  current                ^                   ^
            //                                     current.next (second)        ^
            //                                                    current.next.next (nextPair)

            // So, 'nextPair' points to [3]. It will be processed in the next iteration.
            // And 'second' points to [2]. It will be swapped with [1] now.

            // STEP 2: Swap nodes.
            // Step 2.1:
            // [2,next is [1]] --> [1,next is [2]]
            second.Next = current;

            // Step 2.2:
            // [2,next is [1]] --> [1,next is [3]] --> [3,next is [4]]
            current.Next = nextPair;

            // Step 2.3:
            // [dummy,next is [2]] --> [2,next is [1]] --> [1,next is [3]] --> [3,next is [4]]
            //   ^                      ^
            // prev               prev.next
            prev.Next = second;

            // Update pointers.
            
            // Before:
            // [dummy,next is [2]] --> [2,next is [1]] --> [1,next is [3]] --> [3,next is [4]] --> [4,next is null]
            //  ^                                           ^
            // prev                                         ^
            //                                           current

            prev = current;
            current = nextPair;

            // After:
            // [dummy,next is [2]] --> [2,next is [1]] --> [1,next is [3]] --> [3,next is [4]] --> [4,next is null]
            //                                              ^                   ^
            //                                            prev                  ^
            //                                                               current
        }

        return dummy.Next;
    }
}
