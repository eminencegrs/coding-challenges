using DailyCodingProblem.Challenges.Year2024.Month07July;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Year2024.Month07July;

public class Day19Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetResult_ThenResultAsExpected(int[] numbers, int[] expectedResult)
    {
        var actualResult = Day19.GetResult(numbers);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetResultNotUsingDivision_ThenResultAsExpected(
        int[] numbers, int[] expectedResult)
    {
        var actualResult = Day19.GetResultNotUsingDivision(numbers);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new [] { 1, 2, 3, 4, 5 }, new [] { 120, 60, 40, 30, 24 } ];
        yield return [ new [] { 3, 2, 1 }, new [] { 2, 3, 6 } ];
        yield return [ new [] { -3, -2, 1 }, new [] { -2, -3, 6 } ];
        yield return [ new [] { 0, 4, 7 }, new [] { 0, 0, 0 } ];
        yield return [ Enumerable.Empty<int>().ToArray(), Enumerable.Empty<int>().ToArray() ];
    }
}
