using System.Collections;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0046_Permutations;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return
        [
            new[] { 1, 2, 3 },
            new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 }
            }
        ];

        yield return
        [
            new[] { 0, 1 },
            new List<IList<int>>
            {
                new List<int> { 0, 1 },
                new List<int> { 1, 0 }
            }
        ];

        yield return
        [
            new[] { 42 },
            new List<IList<int>>
            {
                new List<int> { 42 }
            }
        ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
