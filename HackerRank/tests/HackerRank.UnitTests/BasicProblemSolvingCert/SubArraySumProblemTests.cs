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
    }
}
