using Shouldly;
using Xunit;

namespace HackerRank.UnitTests;

public class SparseArraysTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenStringAndQueries_WhenGetSides_ThenResultAsExpected(
        List<string> strings, List<string> queries, List<int> expectedResult)
    {
        var actualResult = SparseArrays.MatchingStrings(strings, queries);
        actualResult.SequenceEqual(expectedResult).ShouldBeTrue();
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new List<string> { "def", "de", "fgh" },
            new List<string> { "de", "lmn", "fgh" },
            new List<int> { 1, 0, 1 }
        ];
        yield return
        [
            new List<string> { "aba", "baba", "aba", "xzxb" },
            new List<string> { "aba", "xzxb", "ab" },
            new List<int> { 2, 1, 0 }
        ];
    }
}
