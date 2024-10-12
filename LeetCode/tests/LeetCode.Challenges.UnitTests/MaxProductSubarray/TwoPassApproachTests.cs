using LeetCode.Challenges.MaxProductSubarray;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.MaxProductSubarray;

public class TwoPassApproachTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArrays_WhenMerge_ThenResultAsExpected(int[] numbers, int expectedResult)
    {
        var actualResult = new TwoPassApproach().GetResult(numbers);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { -2, 0, -1 }, 0];
        yield return [new[] { 2, 3, -2, 4 }, 6];
        yield return [new[] { 2, -5, -2, -4, 3 }, 24];
    }
}
