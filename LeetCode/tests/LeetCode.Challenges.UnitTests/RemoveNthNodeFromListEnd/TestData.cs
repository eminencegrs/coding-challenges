using System.Collections;
using LeetCode.Challenges.RemoveNthNodeFromListEnd;

namespace LeetCode.Challenges.UnitTests.RemoveNthNodeFromListEnd;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));
        yield return [ head, 2, expected ];

        head = new ListNode(1);
        yield return [ head, 1, null ];

        head = new ListNode(1, new ListNode(2));
        yield return [ head, 1, new ListNode(1) ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
