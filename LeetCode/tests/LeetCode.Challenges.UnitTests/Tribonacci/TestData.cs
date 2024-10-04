using System.Collections;

namespace LeetCode.Challenges.UnitTests.Tribonacci;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [0, 0];
        yield return [1, 1];
        yield return [2, 1];
        yield return [3, 2];
        yield return [4, 4];
        yield return [5, 7];
        yield return [25, 1389537];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
