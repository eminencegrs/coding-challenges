using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems32xx.N_3264_FinalArrayStateAfterKMultiplicationOperationsI;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [new[] { 2, 1, 3, 5, 6 }, 5, 2, new[] { 8, 4, 6, 5, 6 }];
        yield return [new[] { 1, 2 }, 3, 4, new[] { 16, 8 }];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
