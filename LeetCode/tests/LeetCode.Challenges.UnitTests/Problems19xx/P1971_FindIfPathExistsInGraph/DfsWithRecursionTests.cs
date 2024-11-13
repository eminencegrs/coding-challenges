using LeetCode.Challenges.Problems19xx.P1971_FindIfPathExistsInGraph;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems19xx.P1971_FindIfPathExistsInGraph;

public class DfsWithRecursionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenGraph_WhenIsValidSerialization_ThenResultAsExpected(
        int n, int[][] edges, int source, int destination, bool expectedResult)
    {
        DfsWithRecursion.ValidPath(n, edges, source, destination).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // (0) -- (1)
        //   \   /
        //    (2)
        yield return [3, new int[][] { [0, 1], [1, 2], [2, 0] }, 0, 2, true];

        //     (1)    (3)
        //    /        |  \
        // (0)         |   (5)
        //    \        |  /
        //     (2)    (4)
        yield return [5, new int[][] { [0, 1], [0, 2], [3, 5], [5, 4], [4, 3] }, 0, 5, false];
    }
}
