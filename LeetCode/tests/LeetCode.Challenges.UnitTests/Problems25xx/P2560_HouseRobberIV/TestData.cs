using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems25xx.P2560_HouseRobberIV;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 2, 3, 5, 9 }, 2, 5];
        yield return [new[] { 2, 7, 9, 3, 1 }, 2, 2];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
