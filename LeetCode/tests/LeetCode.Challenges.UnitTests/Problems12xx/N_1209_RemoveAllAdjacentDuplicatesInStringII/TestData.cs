using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems12xx.N_1209_RemoveAllAdjacentDuplicatesInStringII;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ "abcd", 2, "abcd" ];
        yield return [ "deeedbbcccbdaa", 3, "aa" ];
        yield return [ "pbbcggttciiippooaais", 2, "ps" ];
        yield return [ "xxxx", 2, "" ];
        yield return [ "xxxx", 3, "x" ];
        yield return [ "xxxx", 4, "" ];
        yield return [ "xxxx", 5, "xxxx" ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
