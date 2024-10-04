using System.Collections;

namespace LeetCode.Challenges.UnitTests.ReverseSubstringsBetweenParentheses;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [ "(abcd)", "dcba" ];
        yield return [ "((abc)def)", "fedabc" ];
        yield return [ "(u(love)i)", "iloveu" ];
        yield return [ "(ed(et(oc))el)", "leetcode" ];
        yield return [ "(ab(cd)ef(gh)ij)", "jighfecdba" ];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
