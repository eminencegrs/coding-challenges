using Xunit;
using LeetCode.Challenges.MinimumSwapsToGroupAllOnesTogether2;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.MinimumSwapsToGroupAllOnesTogether2;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArrays_WhenMerge_ThenResultAsExpected(int[] nums, int expectedResult)
    {
        var actualResult = SlidingWindowSolution.MinSwaps(nums);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new [] { 0, 1, 0, 1, 1, 0, 0 }, 1 ];
        yield return [ new [] { 0, 1, 1, 1, 0, 0, 1, 1, 0 }, 2 ];
        yield return [ new [] { 1, 1, 0, 0, 1 }, 0 ];
        yield return [ new [] { 0, 0, 1, 0, 0 }, 0 ];
        yield return [ new [] { 0, 0, 0, 0, 0 }, 0 ];
    }
}
