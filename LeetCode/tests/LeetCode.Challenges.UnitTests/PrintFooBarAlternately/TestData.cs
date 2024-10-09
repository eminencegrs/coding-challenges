using System.Collections;

namespace LeetCode.Challenges.UnitTests.PrintFooBarAlternately;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [1, "foobar"];
        yield return [2, "foobarfoobar"];
        yield return [3, "foobarfoobarfoobar"];
        yield return [5, "foobarfoobarfoobarfoobarfoobar"];
        yield return [10, "foobarfoobarfoobarfoobarfoobarfoobarfoobarfoobarfoobarfoobar"];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
