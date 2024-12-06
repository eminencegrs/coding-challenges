using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems25xx.N_2554_MaximumNumberOfIntegersToChooseFromRangeI;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        var n = 5;
        var maxSum = 6;
        var expectedCount = 2;
        yield return [new[] { 1, 6, 5 }, n, maxSum, expectedCount];

        n = 8;
        maxSum = 1;
        expectedCount = 0;
        yield return [new[] { 1, 2, 3, 4, 5, 6, 7 }, n, maxSum, expectedCount];

        n = 7;
        maxSum = 50;
        expectedCount = 7;
        yield return [new[] { 11 }, n, maxSum, expectedCount];

        n = 3016;
        maxSum = 240;
        expectedCount = 17;
        yield return
        [
            new[]
            {
                176, 36, 104, 125, 188, 152, 101, 47, 51, 65, 39, 174, 29, 55, 13, 138, 79, 81, 175, 178,
                42, 108, 24, 80, 183, 190, 123, 20, 139, 22, 140, 62, 58, 137, 68, 148, 172, 76, 173, 189,
                151, 186, 153, 57, 142, 105, 133, 114, 165, 118, 56, 59, 124, 82, 49, 94, 8, 146, 109, 14,
                85, 44, 60, 181, 95, 23, 150, 97, 28, 182, 157, 46, 160, 155, 12, 67, 135, 117, 2, 25, 74,
                91, 71, 98, 127, 120, 130, 107, 168, 18, 69, 110, 61, 147, 145, 38
            },
            n,
            maxSum,
            expectedCount
        ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
