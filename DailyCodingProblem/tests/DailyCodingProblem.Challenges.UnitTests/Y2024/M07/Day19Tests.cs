using DailyCodingProblem.Challenges.Y2024.M07;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M07;

public class Day19Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetResult_ThenResultAsExpected(int[] numbers, int[] expectedResult)
    {
        var actualResult = Day19Task.GetResult(numbers);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetResultNotUsingDivision_ThenResultAsExpected(
        int[] numbers, int[] expectedResult)
    {
        var actualResult = Day19Task.GetResultNotUsingDivision(numbers);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 1, 2, 3, 4, 5 }, new[] { 120, 60, 40, 30, 24 }];
        yield return [new[] { 3, 2, 1 }, new[] { 2, 3, 6 }];
        yield return [new[] { -3, -2, 1 }, new[] { -2, -3, 6 }];
        yield return [new[] { 0, 4, 7 }, new[] { 0, 0, 0 }];
        yield return [Array.Empty<int>(), Array.Empty<int>()];
    }
}
