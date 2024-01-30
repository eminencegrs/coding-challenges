using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class SubarrayDivisionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenChocolateBar_WhenCallGetNumber_ThenResultAsExpected(
        List<int> chocolateBar, int day, int month, int expectedResult)
    {
        var sut = new SubarrayDivision();
        var actualResult = sut.GetNumber(chocolateBar, day, month);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                new List<int> { 2, 2, 1, 3, 2 }, 4, 2, 2
            },
            new object[]
            {
                new List<int> { 4 }, 4, 1, 1
            },
            new object[]
            {
                new List<int> { 1, 2, 1, 3, 2 }, 3, 2, 2
            },
            new object[]
            {
                new List<int> { 1, 1, 1, 1, 1, 1 }, 3, 2, 0
            }
        };
}
