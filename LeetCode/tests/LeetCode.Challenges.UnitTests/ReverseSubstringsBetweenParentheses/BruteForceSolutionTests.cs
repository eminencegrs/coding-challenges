using LeetCode.Challenges.ReverseSubstringsBetweenParentheses;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ReverseSubstringsBetweenParentheses;

public class BruteForceSolutionTests
{
    [Theory(Skip = "Fails. Not implemented.")]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenReverse_ThenResultAsExpected(string input, string expectedResult)
    {
        var actualResult = new BruteForceSolution().Reverse(input);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
