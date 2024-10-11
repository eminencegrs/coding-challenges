using DailyCodingProblem.Challenges.Y2024.M10;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M10;

public class Day11Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenGetNumberOfParenthesesToRemove_ThenResultAsExpected(
        string parentheses, int expected)
    {
        Day11Task.GetNumberOfParenthesesToRemove(parentheses).ShouldBe(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        // Balanced cases (expected 0 removals).
        yield return ["()", 0];
        yield return ["(())", 0];
        yield return ["(()())", 0];
        yield return ["((()))", 0];

        // Unbalanced cases.
        yield return ["()())()", 1];
        yield return ["())", 1];
        yield return ["(((", 3];
        yield return [")))", 3];

        // Mixed cases.
        yield return [")(", 2];
        yield return ["(()", 1];
        yield return ["())(", 2];
        yield return ["(()))(", 2];

        // Edge cases.
        yield return ["", 0];
        yield return ["((((" , 4];
        yield return ["))))" , 4];
        yield return ["(((())))" , 0];
    }
}
