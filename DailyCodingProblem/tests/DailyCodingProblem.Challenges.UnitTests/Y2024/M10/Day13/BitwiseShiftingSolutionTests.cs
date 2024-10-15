using DailyCodingProblem.Challenges.Y2024.M10.Day13;
using FluentAssertions;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M10.Day13;

public class BitwiseShiftingSolutionTests
{
    [Theory]
    [InlineData(-10, 10)]
    public void GivenNegativeDividend_WhenDivide2PositiveIntegers_ThenExceptionThrown(int dividend, int divisor)
    {
        var action = () => BitwiseShiftingSolution.Divide2PositiveIntegers(dividend, divisor);
        action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Theory]
    [InlineData(10, -10)]
    [InlineData(10, 0)]
    public void GivenInvalidDivisor_WhenDivide2PositiveIntegers_ThenExceptionThrown(int dividend, int divisor)
    {
        var action = () => BitwiseShiftingSolution.Divide2PositiveIntegers(dividend, divisor);
        action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenDividendAndDivisor_WhenDivide2PositiveIntegers_ThenResultAsExpected(
        int dividend, int divisor, int expectedResult)
    {
        BitwiseShiftingSolution.Divide2PositiveIntegers(dividend, divisor).ShouldBe(expectedResult);
    }
}
