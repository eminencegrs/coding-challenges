using System.Collections;

namespace LeetCode.Challenges.UnitTests.StoreListOfNumbersAsSingleNumber;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 2, 4, 1 }, 47_000_005];
        yield return [new[] { 0 }, 1];
        yield return [new[] { 10, 20, 30 }, 29_460_000_031];
        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 25_678_050_355_000_011];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
