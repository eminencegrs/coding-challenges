using HackerRank.BasicProblemSolvingCert;
using Shouldly;
using Xunit;

namespace HackerRank.UnitTests.BasicProblemSolvingCert;

public class SubArraySumProblemTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenStringAndQueries_WhenGetSides_ThenResultAsExpected(
        List<int> numbers, List<List<int>> queries, List<long> expected)
    {
        var actualResult = SubArraySumProblem.Solve(numbers, queries);
        actualResult.SequenceEqual(expected).ShouldBeTrue();
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new List<int> { 5, 10, 10 },
            new List<List<int>> { new() { 1, 2, 5 } },
            new List<long> { 15 }
        ];

        yield return
        [
            new List<int> { 10, 0, 20 },
            new List<List<int>> { new() { 1, 2, 10 }, new() { 2, 3, 20 } },
            new List<long> { 20, 40 }
        ];

        yield return
        [
            new List<int> { 1, 0, 3, 4, 5, 0, 0, 8, 9 },
            new List<List<int>>
            {
                new() { 1, 3, 2 },
                new() { 4, 6, 4 },
                new() { 7, 9, 8 },
                new() { 3, 7, 16 },
                new() { 1, 9, 32 },
            },
            new List<long> { 6, 13, 25, 44, 126 }
        ];
    }
}
