using DailyCodingProblem.Challenges.Y2024.M09;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M09;

public class Day16Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenVariableAndExponent_WhenCallRecursivePow_ThenResultAsExpected(
        int x, int n, double expectedResult)
    {
        var actualResult = Day16Task.RecursivePow(x, n);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ 0, 0, 0 ];
        yield return [ 0, 1, 0 ];
        yield return [ 1, 0, 1 ];
        yield return [ 1, 1, 1 ];
        yield return [ -2, -2, (1.0/4) ];
        yield return [ -2, 2, 4 ];
        yield return [ -2, -3, (-1.0/8) ];
        yield return [ -2, 3, -8 ];
        yield return [ 2, -3, (1.0/8) ];
        yield return [ 2, 3, 8 ];
        yield return [ 2, 10, 1024 ];
        yield return [ 3, -3, (1.0/27) ];
        yield return [ 3, 3, 27 ];
    }
}
