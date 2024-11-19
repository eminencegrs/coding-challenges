using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems19xx.N_1971_FindIfPathExistsInGraph;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
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

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
