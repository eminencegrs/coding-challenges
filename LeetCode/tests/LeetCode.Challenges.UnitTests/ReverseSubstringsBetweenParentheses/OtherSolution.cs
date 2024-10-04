using LeetCode.Challenges.ReverseSubstringsBetweenParentheses;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ReverseSubstringsBetweenParentheses;

public class OtherSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenReverse_ThenResultAsExpected(string input, string expectedResult)
    {
        var actualResult = new OtherSolution().Reverse(input);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
