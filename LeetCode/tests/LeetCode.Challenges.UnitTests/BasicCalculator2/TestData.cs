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
        yield return [ "100 / 10 / 5 / 2 / 1", 1 ];
        yield return [ "100 / 3 * 10 + 3", 333 ];
        yield return [ "1*2-3+4*5", 19 ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
