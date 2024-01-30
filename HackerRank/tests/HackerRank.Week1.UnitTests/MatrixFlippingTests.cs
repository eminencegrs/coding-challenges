using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class MatrixFlippingTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenMatrix_WhenCallGetUpperLeftQuadrantMaxSum_ThenResultAsExpected(List<List<int>> matrix, int expectedResult)
    {
        var sut = new MatrixFlipping();
        var actualResult = sut.GetUpperLeftQuadrantMaxSum(matrix);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                new List<List<int>>
                {
                    new() { 112, 42, 93, 119 },
                    new() { 56, 125, 56, 49 },
                    new() { 15, 78, 101, 43 },
                    new() { 62, 98, 114, 108 },
                },
                414
            },
            new object[]
            {
                new List<List<int>>
                {
                    new() { 1, 2, 3, 4, 5 },
                    new() { 6, 7, 8, 9, 10 },
                    new() { 11, 12, 13, 14, 15 },
                    new() { 16, 17, 18, 19, 20 },
                    new() { 21, 22, 23, 24, 25 },
                },
                88
            },
            new object[]
            {
                new List<List<int>>
                {
                    new() { 25, 10, 11, 20, 21 },
                    new() { 2, 99, 12, 19, 22 },
                    new() { 3, 8, 13, 18, 23 },
                    new() { 4, 7, 14, 17, 24 },
                    new() { 5, 6, 15, 16, 1 },
                },
                168
            },
        };
}
