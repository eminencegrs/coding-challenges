using LeetCode.Challenges.LongestPalindromicSubstring;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.LongestPalindromicSubstring;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenGetTheLongestPalindrome_ThenResultAsExpected(string initialString, string expectedResult)
    {
        var actualResult = Solution.GetTheLongestPalindrome(initialString);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ "babad", "bab" ];
        yield return [ "cbbd", "bb" ];
    }
}
