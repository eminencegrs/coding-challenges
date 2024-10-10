using DailyCodingProblem.Challenges.Y2024.M10;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M10;

public class Day10Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetXorY_ThenResultAsExpected(int x, int y, int b, int expected)
    {
        Day10Task.GetXorY(x, y, b).ShouldBe(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        int x = 5, y = 7, b = 1, expected = 5;
        yield return [ x, y, b, expected ];

        x = 5; y = 7; b = 0; expected = 7;
        yield return [ x, y, b, expected ];

        x = int.MaxValue; y = 1; b = 1; expected = int.MaxValue;
        yield return [ x, y, b, expected ];

        x = 1; y = int.MaxValue; b = 0; expected = int.MaxValue;
        yield return [ x, y, b, expected ];
    }
}
