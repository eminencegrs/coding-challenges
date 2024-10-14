using HackerRank.BasicProblemSolvingCert;
using Shouldly;
using Xunit;

namespace HackerRank.UnitTests.BasicProblemSolvingCert;

public class MaxCostProblemTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenStringAndQueries_WhenGetSides_ThenResultAsExpected(
        List<int> costs, List<string> labels, int dailyCount, int expectedResult)
    {
        var actualResult = MaxCostProblem.Solve(costs, labels, dailyCount);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new List<int> { 0, 3, 2, 3, 4 },
            new List<string> { "legal", "legal", "illegal", "legal", "legal" },
            1,
            5
        ];
    }
}
