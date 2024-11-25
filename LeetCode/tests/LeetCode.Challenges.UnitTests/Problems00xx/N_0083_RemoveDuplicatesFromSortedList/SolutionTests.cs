using LeetCode.Challenges.Problems00xx.N_0083_RemoveDuplicatesFromSortedList;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0083_RemoveDuplicatesFromSortedList;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void GivenListNode_WhenDeleteDuplicates_ThenResultAsExpected(ListNode? head, ListNode? expectedResult)
    {
        Solution.DeleteDuplicates(head).ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestCases()
    {
        // Case 1: List with duplicates [1, 1, 2] -> [1, 2]
        var head = new ListNode(1, new ListNode(1, new ListNode(2)));
        var expectedResult = new ListNode(1, new ListNode(2));
        yield return [head, expectedResult];

        // Case 2: List with all elements identical [1, 1, 1] -> [1]
        head = new ListNode(1, new ListNode(1, new ListNode(1)));
        expectedResult = new ListNode(1);
        yield return [head, expectedResult];

        // Case 3: List with interspersed duplicates [1, 2, 2, 3] -> [1, 2, 3]
        head = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(3))));
        expectedResult = new ListNode(1, new ListNode(2, new ListNode(3)));
        yield return [head, expectedResult];

        // Case 4: List with trailing duplicates [1, 2, 3, 3, 4] -> [1, 2, 3, 4]
        head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4)))));
        expectedResult = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        yield return [head, expectedResult];

        // Case 5: List with no duplicates [1, 2, 3, 4, 5] -> [1, 2, 3, 4, 5]
        head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        expectedResult = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        yield return [head, expectedResult];

        // Case 6: Single-node list [1] -> [1]
        head = new ListNode(1);
        expectedResult = new ListNode(1);
        yield return [head, expectedResult];

        // Case 7: Empty list -> Empty list
        head = null;
        expectedResult = null;
        yield return [head!, expectedResult!];

        // Case 8: Complex list with duplicates [1, 1, 1, 2, 2, 3, 3] -> [1, 2, 3]
        head = new ListNode(
            1, new ListNode(
                1, new ListNode(
                    1, new ListNode(
                        2, new ListNode(
                            2, new ListNode(
                                3, new ListNode(3)))))));

        expectedResult = new ListNode(1, new ListNode(2, new ListNode(3)));
        yield return [head, expectedResult];
    }
}
