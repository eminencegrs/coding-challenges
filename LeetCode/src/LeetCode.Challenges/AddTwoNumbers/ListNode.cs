namespace LeetCode.Challenges.AddTwoNumbers;

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
