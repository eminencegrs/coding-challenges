using DailyCodingProblem.Challenges.Y2024.M08;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M08;

public class Day04Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetResultByUsingBruteForce_ThenResultAsExpected(int[] numbers, int k, int[] expectedResult)
    {
        var actualResult = Day04Task.BruteForceApproach.GetResult(numbers, k);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetResultByUsingSlidingWindow_ThenResultAsExpected(int[] numbers, int k, int[] expectedResult)
    {
        var actualResult = Day04Task.SlidingWindowApproach.GetResult(numbers, k);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new[] { 10, 5, 2, 7, 8, 7 }, 3, new[] { 10, 7, 8, 8 } ];
        yield return [ new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3, new[] { 3, 3, 5, 5, 6, 7 } ];
        yield return [ new[] { 1 }, 1, new[] { 1 } ];
        yield return [ new[] { 1, -1 }, 1, new[] { 1, -1 } ];
    }
}
