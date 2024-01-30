using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class DiagonalDifferenceTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenMatrix_WhenCallCalculate_ThenResultAsExpected(List<List<int>> matrix, int expectedResult)
    {
        var sut = new DiagonalDifference();
        var actualResult = sut.Calculate(matrix);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                new List<List<int>>
                {
                    new() { 7, 8, 9 },
                    new() { 3, 2, 1 },
                    new() { 4, 5, 6 },
                },
                0
            },
            new object[]
            {
                new List<List<int>>
                {
                    new() { 3, 0, 1 },
                    new() { 0, 0, 0 },
                    new() { 1, 0, 3 },
                },
                4
            }
        };
}