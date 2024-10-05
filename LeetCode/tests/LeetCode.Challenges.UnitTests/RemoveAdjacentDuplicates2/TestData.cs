using System.Collections;

namespace LeetCode.Challenges.UnitTests.RemoveAdjacentDuplicates2;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ "abcd", 2, "abcd" ];
        yield return [ "deeedbbcccbdaa", 3, "aa" ];
        yield return [ "pbbcggttciiippooaais", 2, "ps" ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
