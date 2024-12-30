namespace LeetCode.Challenges.AddTwoNumbers;

public static partial class Solution
{
    public static ListNode? GetResult(ListNode? firstNode, ListNode? secondNode)
    {
        var root = new ListNode();
        var current = root;
        var carryOver = 0;

        while (firstNode != null || secondNode != null)
        {
            var first = firstNode?.Value ?? 0;
            var second = secondNode?.Value ?? 0;
            var sum = carryOver + first + second;
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
}
