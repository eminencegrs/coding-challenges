using System.Collections;

// ReSharper disable once CheckNamespace
namespace LeetCode.Challenges.UnitTests.TrappingRainWater;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }, 6];
        yield return [new[] { 4, 2, 0, 3, 2, 5 }, 9];
        yield return [new[] { 3, 0, 1, 0, 4, 0, 2 }, 10];
        yield return [new[] { 3, 0, 2, 0, 4 }, 7];
        yield return [new[] { 0, 1, 0, 0, 0, 0, 0, 0, 0, 3 }, 7];
        yield return [new[] { 0, 1, 0, 0, 0, 0, 0, 0, 4, 0 }, 6];
        yield return [new[] { 0, 1, 0, 0, 0, 2, 0, 0, 4, 0 }, 7];
        yield return [new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 }, 0];
        yield return [new[] { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 0];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
