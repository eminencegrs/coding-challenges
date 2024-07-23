using System.Collections;

namespace LeetCode.Challenges.UnitTests.Pow;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ 2.00000,          2,    4.00000 ];
        yield return [ 2.00000,          3,    8.00000 ];
        yield return [ 2.00000,          4,   16.00000 ];
        yield return [ 2.00000,         10, 1024.00000 ];
        yield return [ 2.10000,          3,    9.26100 ];
        yield return [ 2.00000,         -2,    0.25000 ];
        yield return [ 1.00000, 2147483647,    1.00000 ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
