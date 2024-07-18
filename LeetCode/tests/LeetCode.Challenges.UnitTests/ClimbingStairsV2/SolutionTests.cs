using LeetCode.Challenges.ClimbingStairsV2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ClimbingStairsV2;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNStepStaircase_WhenClimbStairs_ThenResultAsExpected(int n, int expectedResult)
    {
        var actualResult = new Solution().ClimbStairs(n);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ 2, 2 ];
        yield return [ 3, 4 ];
        yield return [ 4, 7 ];
        yield return [ 5, 13 ];
        yield return [ 7, 44 ];
    }
}
