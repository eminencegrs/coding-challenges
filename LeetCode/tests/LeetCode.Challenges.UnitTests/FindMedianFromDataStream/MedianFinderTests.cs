using FluentAssertions;
using LeetCode.Challenges.FindMedianFromDataStream;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.FindMedianFromDataStream;

public class MedianFinderTests
{
    [Theory]
    [InlineData(new[] { 1 }, 1)]
    [InlineData(new[] { 1, 2 }, 1.5)]
    [InlineData(new[] { 1, 2, 3 }, 2)]
    [InlineData(new[] { 1, 2, 3, 4 }, 2.5)]
    [InlineData(new[] { 2, 1, 5, 7, 2, 0, 5 }, 2)]
    [InlineData(new[] { 3, 6, 9, 12 }, 7.5)]
    [InlineData(new[] { -1, -2, -3 }, -2)]
    [InlineData(new[] { -10, -20, -30, -40, -50 }, -30)]
    public void GivenNumbers_WhenGetMedian_ThenResultAsExpected(int[] numbers, double expectedResult)
    {
        var cut = new MedianFinder();
        foreach (var number in numbers)
        {
            cut.AddNumber(number);
        }

        var actualResult = cut.GetMedian();
        actualResult.ShouldBe(expectedResult);
    }

    [Fact]
    public void GivenNoNumbers_WhenGetMedian_ThenExceptionThrown()
    {
        var cut = new MedianFinder();
        var action = () => cut.GetMedian();
        action.Should().Throw<InvalidOperationException>();
    }
}
