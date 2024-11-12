using LeetCode.Challenges.Problems0XX.P024_SwapNodesInPairs;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems0XX.P024_SwapNodesInPairs;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenLinkedList_WhenSwapPairs_ThenResultAsExpected(ListNode head, ListNode expectedResult)
    {
        Solution.SwapPairs(head).ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // 1 --> 2 --> 3 --> 4
        // 2 --> 1 --> 4 --> 3
        var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        var expectedResult = new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3))));
        yield return [head, expectedResult];

        yield return [null!, null!];

        yield return [new ListNode(1), new ListNode(1)];

        // 1 --> 2 --> 3
        // 2 --> 1 --> 3
        head = new ListNode(1, new ListNode(2, new ListNode(3)));
        expectedResult = new ListNode(2, new ListNode(1, new ListNode(3)));
        yield return [head, expectedResult];
    }
}
