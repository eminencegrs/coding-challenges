using LeetCode.Challenges.Problems19xx.N_1971_FindIfPathExistsInGraph;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems19xx.N_1971_FindIfPathExistsInGraph;

public class DfsWithRecursionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenGraph_WhenValidPath_ThenResultAsExpected(
        int n, int[][] edges, int source, int destination, bool expectedResult)
    {
        DfsWithRecursion.ValidPath(n, edges, source, destination).ShouldBe(expectedResult);
    }
}
