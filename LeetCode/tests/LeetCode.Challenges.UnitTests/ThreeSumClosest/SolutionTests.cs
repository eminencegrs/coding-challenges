using LeetCode.Challenges.ThreeSumClosest;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ThreeSumClosest;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenCallGetResult_ThenResultAsExpected(int[] numbers, int target, int expectedResult)
    {
        var actualResult = Solution.GetResult(numbers, target);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new[] { 0, 0, 0 }, 1, 0 ];
        yield return [ new[] { 0, 1, 2 }, 0, 3 ];
        yield return [ new[] { -1, 2, 1, -4 }, 1, 2 ];
        yield return [ new[] { -10, -6, 0, 1, 3, 9 }, -4, -3 ];
        yield return [ new[] { 4, 0, 5, -5, 3, 3, 0, -4, -5 }, -2, -2 ];
    }
}
