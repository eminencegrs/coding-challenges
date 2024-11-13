using LeetCode.Challenges.Problems19xx.P1971_FindIfPathExistsInGraph;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems19xx.P1971_FindIfPathExistsInGraph;

public class DfsWithStackTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenGraph_WhenValidPath_ThenResultAsExpected(
        int n, int[][] edges, int source, int destination, bool expectedResult)
    {
        DfsWithStack.ValidPath(n, edges, source, destination).ShouldBe(expectedResult);
    }
}
