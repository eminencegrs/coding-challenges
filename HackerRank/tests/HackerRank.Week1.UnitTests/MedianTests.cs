using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class MedianTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenListOfNumbers_WhenCallSort_ThenResultAsExpected(List<int> items, int expectedResult)
    {
        var sut = new Median();
        var actualResult = sut.Get(items);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                // 1 2 2 3 5 7 8
                new List<int> { 2, 1, 8, 5, 2, 7, 3 },
                3
            },
            new object[]
            {
                // 1 1 2 4 4 5 6 7
                new List<int> { 7, 4, 1, 5, 2, 6, 1, 4 },
                4
            }
        };
}