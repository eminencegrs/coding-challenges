namespace LeetCode.Challenges.AddTwoNumbers;

public static class Solution
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

    public class ListNode
    {
        public ListNode(int value = 0, ListNode? next = null)
        {
            this.Value = value;
            this.Next = next;
        }

        public int Value { get; set; }
        public ListNode? Next { get; set; }
    }
}
