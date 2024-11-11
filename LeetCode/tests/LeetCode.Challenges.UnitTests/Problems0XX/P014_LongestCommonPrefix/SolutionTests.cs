using LeetCode.Challenges.Problems0XX.P014_LongestCommonPrefix;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems0XX.P014_LongestCommonPrefix;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenStrings_WhenLongestCommonPrefix_ThenResultAsExpected(
        string[] strings, string expectedResult)
    {
        Solution.LongestCommonPrefix(strings).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { "abcd", "abcef", "abcxy" }, "abc"];
        yield return [new[] { "flower", "flow", "flight" }, "fl"];
        yield return [new[] { "dog", "racecar", "car" }, ""];
        yield return [new[] { "apple" }, "apple"];
        yield return [new[] { "a", "a", "a" }, "a"];
        yield return [new[] { "abc", "abcd", "ab" }, "ab"];
        yield return [new[] { "prefix", "preach", "prevent" }, "pre"];
        yield return [new[] { "xylophone", "xylene", "xylitol" }, "xyl"];
        yield return [new[] { "banana", "band", "banter" }, "ban"];
        yield return [new[] { "hello", "world" }, ""];
        yield return [Array.Empty<string>(), ""];
    }
}
