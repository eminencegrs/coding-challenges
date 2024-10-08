using LeetCode.Challenges.GenerateParentheses;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.GenerateParentheses;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumberOfPairs_WhenGenerateParenthesis_ThenResultAsExpected(
        int pairsNumber, ICollection<string> expectedResult)
    {
        var actualResult = new Solution().GenerateParenthesis(pairsNumber);
        actualResult.Count.ShouldBe(expectedResult.Count);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ 0, new [] { "" } ];
        yield return [ 1, new [] { "()" } ];
        yield return [ 2, new [] { "(())", "()()" } ];
        yield return [ 3, new [] { "((()))","(()())","(())()","()(())","()()()" } ];
        yield return [ 4, new []
        {
            "(((())))",
            "((()()))",
            "((())())",
            "((()))()",
            "(()(()))",
            "(()()())",
            "(()())()",
            "(())(())",
            "(())()()",
            "()((()))",
            "()(()())",
            "()(())()",
            "()()(())",
            "()()()()"
        } ];
    }
}
