using System.Collections;

namespace LeetCode.Challenges.UnitTests.PrintInOrder;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ new[] { 1, 2, 3 } ];
        yield return [ new[] { 1, 3, 2 } ];
        yield return [ new[] { 2, 1, 3 } ];
        yield return [ new[] { 2, 3, 1 } ];
        yield return [ new[] { 3, 1, 2 } ];
        yield return [ new[] { 3, 2, 1 } ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
