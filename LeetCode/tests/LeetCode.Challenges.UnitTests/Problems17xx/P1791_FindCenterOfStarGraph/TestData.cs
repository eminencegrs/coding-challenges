using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems17xx.P1791_FindCenterOfStarGraph;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new int[][] { [1,2],[2,3],[4,2] }, 2];
        yield return [new int[][] { [1,2],[5,1],[1,3],[1,4] }, 1];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
