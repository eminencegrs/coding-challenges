using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems21xx.N_2109_AddingSpacesToString;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return ["LeetcodeHelpsMeLearn", new[] { 8, 13, 15 }, "Leetcode Helps Me Learn"];
        yield return ["icodeinpython", new[] { 1, 5, 7, 9 }, "i code in py thon"];
        yield return ["spacing", new[] { 0, 1, 2, 3, 4, 5, 6 }, " s p a c i n g"];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
