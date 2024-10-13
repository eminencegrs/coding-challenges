using System.Collections;

namespace LeetCode.Challenges.UnitTests.ContainsDuplicate2;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 1, 2, 3, 1 }, 3, true];
        yield return [new[] { 1, 0, 1, 1 }, 1, true];
        yield return [new[] { 1, 2, 3, 1, 2, 3 }, 2, false];
        yield return [new[] { 99, 99 }, 2, true];
        yield return [new[] { 1, 2, 1 }, 0, false];
        yield return [new[] { 0, 1, 2, 3, 2, 5 }, 3, true];
        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9 }, 3, true];
        yield return [new[] { 1, 2, 2, 3 }, 3, true];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
