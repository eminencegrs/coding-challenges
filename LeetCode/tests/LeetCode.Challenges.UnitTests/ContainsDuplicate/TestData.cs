using System.Collections;

namespace LeetCode.Challenges.UnitTests.ContainsDuplicate;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 1, 2, 3, 1 }, true];
        yield return [new[] { 1, 2, 3, 4 }, false];
        yield return [new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
