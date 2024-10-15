using System.Collections;

namespace LeetCode.Challenges.UnitTests.TwoSum;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 }];
        yield return [new[] { 3, 2, 4 }, 6, new[] { 1, 2 }];
        yield return [new[] { 3, 3 }, 6, new[] { 0, 1 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
