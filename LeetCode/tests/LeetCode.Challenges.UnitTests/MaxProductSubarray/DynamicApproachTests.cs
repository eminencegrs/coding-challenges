using LeetCode.Challenges.MaxProductSubarray;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.MaxProductSubarray;

public class DynamicApproachTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenMaxProduct_ThenResultAsExpected(int[] numbers, int expectedResult)
    {
        var actualResult = new DynamicApproach().MaxProduct(numbers);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { -2, 0, -1 }, 0];
        yield return [new[] { 2, 3, -2, 4 }, 6];
        yield return [new[] { 2, -5, -2, -4, 3 }, 24];
    }
}
