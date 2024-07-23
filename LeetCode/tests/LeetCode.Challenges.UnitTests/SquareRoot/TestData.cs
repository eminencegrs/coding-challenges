using System.Collections;

namespace LeetCode.Challenges.UnitTests.SquareRoot;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ 0, 0 ];
        yield return [ 1, 1 ];
        yield return [ 3, 1 ];
        yield return [ 8, 2 ];
        yield return [ 9, 3 ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
