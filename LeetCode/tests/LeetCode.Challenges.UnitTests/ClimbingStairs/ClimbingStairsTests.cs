using LeetCode.Challenges.ClimbingStairs;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ClimbingStairs;

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
        yield return [ 3, 3 ];
        yield return [ 5, 8 ];
    }
}
