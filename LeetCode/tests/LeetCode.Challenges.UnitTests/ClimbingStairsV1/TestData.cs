using System.Collections;

namespace LeetCode.Challenges.UnitTests.ClimbingStairsV1;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ 2, 2 ];
        yield return [ 3, 3 ];
        yield return [ 4, 5 ];
        yield return [ 5, 8 ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
