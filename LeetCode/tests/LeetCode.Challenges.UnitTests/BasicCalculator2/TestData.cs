using System.Collections;

namespace LeetCode.Challenges.UnitTests.BasicCalculator2;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ "3+2*2", 7 ];
        yield return [ " 3/2 ", 1 ];
        yield return [ " 3+5 / 2 ", 5 ];
        yield return [ "42", 42 ];
        yield return [ " 3 0* 2 + 4 /3-5 * 1 0", 11 ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
