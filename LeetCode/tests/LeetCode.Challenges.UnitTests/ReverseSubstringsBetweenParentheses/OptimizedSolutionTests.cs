using LeetCode.Challenges.ReverseSubstringsBetweenParentheses;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ReverseSubstringsBetweenParentheses;

public class OptimizedSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenReverse_ThenResultAsExpected(string input, string expectedResult)
    {
        var actualResult = new OptimizedSolution().Reverse(input);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
