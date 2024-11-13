using LeetCode.Challenges.Problems00xx.P0019_RemoveNthNodeFromTheEndOfList;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.P0019_RemoveNthNodeFromTheEndOfList;

public class TwoPointerSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenListAndNodeNumber_WhenRemoveNthFromEnd_ThenResultAsExpected(
        ListNode head, int n, ListNode? expectedResult)
    {
        TwoPointerSolution.RemoveNthFromEnd(head, n).ShouldBeEquivalentTo(expectedResult);
    }
}
