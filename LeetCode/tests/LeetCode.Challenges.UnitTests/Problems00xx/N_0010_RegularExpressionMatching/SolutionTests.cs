using FluentAssertions;
using LeetCode.Challenges.Problems00xx.N_0010_RegularExpressionMatching;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0010_RegularExpressionMatching;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenStringAndPattern_WhenCallIsMatch_ThenNotImplementedExceptionThrown(
        string str, string pattern, bool expectedResult)
    {
        var action = () => Solution.IsMatch(str, pattern);
        action.Should().Throw<NotImplementedException>();
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return ["aa", "a", false];
        yield return ["aa", "a*", true];
        yield return ["ab", ".*", true];
    }
}
