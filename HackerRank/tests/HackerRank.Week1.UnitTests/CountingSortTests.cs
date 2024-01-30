using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class CountingSortTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenListOfNumbers_WhenCallSort_ThenResultAsExpected(List<int> array, List<int> expectedResult)
    {
        var sut = new CountingSort();
        var actualResult = sut.Sort(array);
        actualResult.ShouldBeInOrder();
        actualResult.SequenceEqual(expectedResult).ShouldBeTrue();
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                new List<int> { 2, 1, 8, 5, 2, 7, 3, 1, 5, 9, 3, 4, 2 },
                new List<int> { 1, 1, 2, 2, 2, 3, 3, 4, 5, 5, 7, 8, 9 }
            },
            new object[]
            {
                new List<int> { 7, 3, 1, 5, 3, 1, 3, 1, 1 },
                new List<int> { 1, 1, 1, 1, 3, 3, 3, 5, 7 }
            }
        };
}
