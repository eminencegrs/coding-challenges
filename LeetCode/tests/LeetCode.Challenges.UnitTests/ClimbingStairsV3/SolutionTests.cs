using LeetCode.Challenges.ClimbingStairsV3;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ClimbingStairsV3;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNStepStaircase_WhenClimbStairs_ThenResultAsExpected(
        int staircaseLength, int expectedResult, int[] stepSizes)
    {
        var actualResult = Solution.ClimbStairs(staircaseLength, stepSizes);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ 2, 2, new[] { 1, 2 } ];
        yield return [ 3, 4, new[] { 1, 2, 3 } ];
        yield return [ 4, 1, new[] { 2, 3 } ];
        yield return [ 5, 2, new[] { 2, 3 } ];
        yield return [ 6, 2, new[] { 2, 3 } ];
        yield return [ 7, 3, new[] { 2, 3 } ];
    }
}
