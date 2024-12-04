using LeetCode.Challenges.Problems00xx.N_0034_FindFirstAndLastOccurrenceInSortedArray;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0034_FindFirstAndLastOccurrenceInSortedArray;

public class TwoPointerSolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbersAndTarget_WhenSearchRange_ThenResultAsExpected(
        int[] numbers, int target, int[] expectedResult)
    {
        DoubleBinarySolution.SearchRange(numbers, target).ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [Array.Empty<int>(), 0, new[] { -1, -1 }];
        yield return [new[] { 1 }, 1, new[] { 0, 0 }];
        yield return [new[] { 1, 2, 3, 4 }, 3, new[] { 2, 2 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 3, new[] { 2, 2 }];
        yield return [new[] { 1, 1, 2, 2, 2, 4, 5 }, 2, new[] { 2, 4 }];
        yield return [new[] { 1, 1, 1, 2, 3, 4, 5 }, 1, new[] { 0, 2 }];
        yield return [new[] { 1, 1, 1, 2, 3, 3, 3 }, 3, new[] { 4, 6 }];
        yield return [new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 }];
        yield return [new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 }];
    }
}
