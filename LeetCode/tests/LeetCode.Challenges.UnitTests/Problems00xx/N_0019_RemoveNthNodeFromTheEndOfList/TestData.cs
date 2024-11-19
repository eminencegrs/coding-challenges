using System.Collections;
using LeetCode.Challenges.Problems00xx.N_0019_RemoveNthNodeFromTheEndOfList;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0019_RemoveNthNodeFromTheEndOfList;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        // 1 --> 2 --> 3 --> 4 --> 5 --> null
        // 1 --> 2 --> 3 --> 5 --> null
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        var expected = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));
        yield return [ head, 2, expected ];

        // 1 --> null
        // null
        head = new ListNode(1);
        yield return [ head, 1, null! ];

        // 1 --> 2
        // 1 --> null
        head = new ListNode(1, new ListNode(2));
        yield return [ head, 1, new ListNode(1) ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
