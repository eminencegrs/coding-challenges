using LeetCode.Challenges.RemoveNthNodeFromListEnd;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.RemoveNthNodeFromListEnd;

public class TwoPointerSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenListAndNodeNumber_WhenRemoveNthFromEnd_ThenResultAsExpected(
        ListNode head, int k, ListNode? expectedResult)
    {
        var actualResult = new TwoPointerSolution().RemoveNthFromEnd(head, k);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
