using DailyCodingProblem.Challenges.Y2024.M07;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M07;

public class Day18Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbersAndTarget_WhenGetResult_ThenResultAsExpected(
        int[] numbers, int target, bool expectedResult)
    {
        bool actualResult = Day18Task.GetResult(numbers, target);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [Array.Empty<int>(), int.MaxValue, false];
        yield return [new[] { 10, 15, 3, 7 }, 17, true];
        yield return [new[] { 10, 7, 6, 3, 1, 0 }, 15, false];
        yield return [new[] { 21, -13, -5, 14, -10, 8, 0, -1, 5, 100 }, 100, true];
        yield return [new[] { 21, -13, -5, 14, -10, 8, 0, -1, 5, 100 }, 0, true];
        yield return [new[] { 21, -13, -5, 14, -10, 8, 0, -1, 5, 100 }, 200, false];
    }
}
