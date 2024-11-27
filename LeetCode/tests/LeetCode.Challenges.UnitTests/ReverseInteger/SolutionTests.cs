using LeetCode.Challenges.ReverseInteger;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ReverseInteger;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenMaxProduct_ThenResultAsExpected(int number, int expectedResult)
    {
        Solution.Reverse(number).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [0, 0];
        yield return [1, 1];
        yield return [-1, -1];
        yield return [12, 21];
        yield return [-12, -21];
        yield return [123, 321];
        yield return [-123, -321];
        yield return [987, 789];
        yield return [998, 899];
        yield return [999, 999];
        yield return [1000, 1];
        yield return [-1000, -1];
        yield return [2147483646, 0];
        yield return [2147483647, 0];
        yield return [-2147483647, 0];
        yield return [-2147483648, 0];
    }
}
