using LeetCode.Challenges.ClimbingStairs.V3;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ClimbingStairs.V3;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNStepStaircase_WhenClimbStairs_ThenResultAsExpected(
        int staircaseLength, int[] stepSizes, int expectedResult)
    {
        var actualResult = Solution.ClimbStairs(staircaseLength, stepSizes);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ 2, new[] { 1, 2 }, 2 ];
        yield return [ 3, new[] { 1, 2, 3 }, 4 ];
        yield return [ 4, new[] { 2, 3 }, 1 ];
        yield return [ 5, new[] { 2, 3 }, 2 ];
        yield return [ 6, new[] { 2, 3 }, 2 ];
        yield return [ 7, new[] { 2, 3 }, 3 ];
    }
}
