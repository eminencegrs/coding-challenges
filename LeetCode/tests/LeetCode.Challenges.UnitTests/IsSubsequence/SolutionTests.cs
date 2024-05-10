using LeetCode.Challenges.IsSubsequence;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.IsSubsequence;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenStrings_WhenCallIsSubsequence_ThenResultAsExpected(
        string originalString, string substring, bool expectedResult)
    {
        var actualResult = new Solution().IsSubsequence(substring, originalString);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ "ahbgdc", "abc", true ];
        yield return [ "ahbgdc", "axc", false ];
    }
}
