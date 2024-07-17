namespace LeetCode.Challenges.AddTwoNumbers;

public static class AddTwoNumbersSolution
{
    public static ListNode? GetResult(ListNode? firstNode, ListNode? secondNode)
    {
        var root = new ListNode();
        var current = root;
        int carryOver = 0;

        while (firstNode != null || secondNode != null)
        {
            int first = firstNode?.Value ?? 0;
            int second = secondNode?.Value ?? 0;
            int sum = carryOver + first + second;
            carryOver = sum / 10;
            current.Next = new ListNode(sum % 10);
            current = current.Next!;

            firstNode = firstNode?.Next;
            secondNode = secondNode?.Next;
        }

        if (carryOver > 0)
        {
            current.Next = new ListNode(carryOver);
        }

        return root.Next;
    }

    // First attempt.
    // public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    // {
    //     var first = 0;
    //     var second = 0;
    //     var factor = 1;
    //     while (l1 != null && l2 != null)
    //     {
    //         first = first + l1.Value * factor;
    //         second = second + l2.Value * factor;
    //         factor *= 10;
    //         l1 = l1.Next;
    //         l2 = l2.Next;
    //     }
    //
    //     var sum = first + second;
    //     ListNode? result = null;
    //     do
    //     {
    //         factor /= 10;
    //         if (factor == 0)
    //         {
    //             break;
    //         }
    //
    //         // TODO: this is incorrect.
    //         var tempValue = sum / factor;
    //         sum %= factor;
    //
    //         if (result == null)
    //         {
    //             result = new ListNode(tempValue, null);
    //         }
    //         else
    //         {
    //             var temp = result;
    //             result = new ListNode(tempValue, temp);
    //         }
    //     } while (factor > 0);
    //
    //     return result;
    // }
}
