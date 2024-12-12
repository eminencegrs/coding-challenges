using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems05xx.N_0506_RelativeRanks;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            new[] { 5, 4, 3, 2, 1 },
            new[] { "Gold Medal", "Silver Medal", "Bronze Medal", "4", "5" }
        ];

        yield return
        [
            new[] { 10, 3, 8, 9, 4 },
            new[] { "Gold Medal", "5", "Bronze Medal", "Silver Medal", "4" }
        ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
