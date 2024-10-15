using DailyCodingProblem.Challenges.Y2024.M10.Day13;
using FluentAssertions;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M10.Day13;

public class BruteForceSolutionTests
{
    [Theory]
    [InlineData(-10, 10)]
    public void GivenNegativeDividend_WhenDivide2PositiveIntegers_ThenExceptionThrown(int dividend, int divisor)
    {
        var action = () => BruteForceSolution.Divide2PositiveIntegers(dividend, divisor);
        action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Theory]
    [InlineData(10, -10)]
    [InlineData(10, 0)]
    public void GivenInvalidDivisor_WhenDivide2PositiveIntegers_ThenExceptionThrown(int dividend, int divisor)
    {
        var action = () => BruteForceSolution.Divide2PositiveIntegers(dividend, divisor);
        action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenDividendAndDivisor_WhenDivide2PositiveIntegers_ThenResultAsExpected(
        int dividend, int divisor, int expectedResult)
    {
        BruteForceSolution.Divide2PositiveIntegers(dividend, divisor).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // Zero dividend.
        yield return [0, 10, 0];

        // Divisor of 1.
        yield return [10, 1, 10];

        // General case.
        yield return [10, 3, 3];

        // Dividend equals divisor.
        yield return [5, 5, 1];

        // Divisor > dividend.
        yield return [2, 10, 0];

        // Larger numbers.
        yield return [100, 5, 20];
        yield return [1000, 10, 100];
    }
}
