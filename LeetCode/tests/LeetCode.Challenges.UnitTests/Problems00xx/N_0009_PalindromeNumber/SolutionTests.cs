using LeetCode.Challenges.Problems00xx.N_0009_PalindromeNumber;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0009_PalindromeNumber;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumber_WhenIsPalindrome_ThenResultAsExpected(int number, bool expectedResult)
    {
        Solution.IsPalindrome(number).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [1, true];
        yield return [11, true];
        yield return [121, true];
        yield return [12321, true];
        yield return [-1, false];
        yield return [12, false];
        yield return [123, false];
        yield return [100, false];
        yield return [-121, false];
    }
}
