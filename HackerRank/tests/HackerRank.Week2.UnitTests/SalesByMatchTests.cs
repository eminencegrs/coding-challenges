using HackerRank.Week2.SalesByMatchTask;
using Shouldly;
using Xunit;

namespace HackerRank.Week2.UnitTests;

public class SalesByMatchTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenListOfNumbers_WhenCallSort_ThenResultAsExpected(int n, List<int> array, int expectedResult)
    {
        var sut = new SalesByMatch();
        var actualResult = sut.GetSockPairs(n, array);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                9,
                new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 },
                3
            },
            new object[]
            {
                10,
                new List<int> { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 },
                4
            }
        };
}
