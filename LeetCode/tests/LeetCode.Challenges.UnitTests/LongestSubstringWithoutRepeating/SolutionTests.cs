using LeetCode.Challenges.LongestSubstringWithoutRepeating;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.LongestSubstringWithoutRepeating;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenGetLengthOfLongestSubstring_ThenResultAsExpected(string input, int expectedResult)
    {
        var actualResult = new Solution().GetLongestSubstringLength(input);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            "abcabcbb", 3
        ];
        yield return
        [
            "bbbbb", 1
        ];
        yield return
        [
            "pwwkew", 3
        ];
    }
}
