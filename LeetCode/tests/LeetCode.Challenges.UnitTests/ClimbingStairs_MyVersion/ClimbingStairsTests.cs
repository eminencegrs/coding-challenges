using LeetCode.Challenges.ClimbingStairs_MyVersion;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ClimbingStairs_MyVersion;

public class ClimbingStairsTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenAddTwoNumbers_ThenResultAsExpected(int n, int expectedResult)
    {
        var actualResult = new Solution().ClimbStairs(n);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ 2, 2 ];
        yield return [ 3, 4 ];
        yield return [ 5, 13 ];
        yield return [ 7, 44 ];
    }
}
