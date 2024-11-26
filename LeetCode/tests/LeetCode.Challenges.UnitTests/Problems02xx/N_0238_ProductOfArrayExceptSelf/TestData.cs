using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems02xx.N_0238_ProductOfArrayExceptSelf;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [Array.Empty<int>(), Array.Empty<int>()];
        yield return [new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 }];
        yield return [new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
