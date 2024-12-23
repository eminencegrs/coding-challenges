using Xunit;
using LeetCode.Challenges.Problems00xx.N_0035_SearchInsertPosition;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0035_SearchInsertPosition;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbersAndTarget_WhenSearchInsert_ThenResultAsExpected(int[] nums, int target, int expected)
    {
        var result = Solution.SearchInsert(nums, target);
        result.ShouldBe(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 1, 3, 5, 6 }, 5, 2];
        yield return [new[] { 1, 3, 5, 6 }, 2, 1];
        yield return [new[] { 1, 3, 5, 6 }, 7, 4];
        yield return [new[] { 1, 3, 5, 6 }, 0, 0];
        yield return [new[] { 1 }, 0, 0];
        yield return [new[] { 1 }, 1, 0];
        yield return [new[] { 1, 3 }, 2, 1];
    }
}
