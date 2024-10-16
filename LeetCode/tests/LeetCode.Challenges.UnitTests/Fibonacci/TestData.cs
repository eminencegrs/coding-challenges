using System.Collections;

namespace LeetCode.Challenges.UnitTests.Fibonacci;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [0, 0];
        yield return [1, 1];
        yield return [2, 1];
        yield return [3, 2];
        yield return [4, 3];
        yield return [5, 5];
        yield return [6, 8];
        yield return [7, 13];
        yield return [8, 21];
        yield return [9, 34];
        yield return [10, 55];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
