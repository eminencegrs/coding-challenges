using System.Collections;

namespace LeetCode.Challenges.UnitTests.ProductOfArrayExceptSelf;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 }];
        yield return [new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
