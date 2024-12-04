using LeetCode.Challenges.Problems00xx.N_0021_MergeTwoSortedLists;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0021_MergeTwoSortedLists;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTwoLinkedList_WhenMergeTwoLists_ThenResultAsExpected(
        ListNode first, ListNode second, ListNode expectedResult)
    {
        Solution.MergeTwoLists(first, second).ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [null!, null!, null!];

        // 1 --> 2 --> 4
        // 1 --> 3 --> 4
        var first = new ListNode(1, new ListNode(2, new ListNode(4)));
        var second = new ListNode(1, new ListNode(3, new ListNode(4)));
        var expectedResult = new ListNode(
            1, new ListNode(
                1, new ListNode(
                    2, new ListNode(
                        3, new ListNode(
                            4, new ListNode(4))))));
        yield return [first, second, expectedResult];

        // 1 --> 1 --> 2
        // 2 --> 2 --> 3 --> 4
        first = new ListNode(1, new ListNode(1, new ListNode(2)));
        second = new ListNode(2, new ListNode(2, new ListNode(3, new ListNode(4))));
        expectedResult = new ListNode(
            1, new ListNode(
                1, new ListNode(
                    2, new ListNode(
                        2, new ListNode(
                            2, new ListNode(
                                3, new ListNode(4)))))));
        yield return [first, second, expectedResult];

        // 1 --> 2 --> 3 --> 5
        // 2 --> 3
        first = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5))));
        second = new ListNode(2, new ListNode(3));
        expectedResult = new ListNode(
            1, new ListNode(
                2, new ListNode(
                    2, new ListNode(
                        3, new ListNode(
                            3, new ListNode(5))))));
        yield return [first, second, expectedResult];

        first = new ListNode(1);
        expectedResult = new ListNode(1);
        yield return [first, null!, expectedResult];
        
        second = new ListNode(2);
        expectedResult = new ListNode(2);
        yield return [null!, second, expectedResult];
    }
}
