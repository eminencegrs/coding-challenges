using LeetCode.Challenges.SingleNumber;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.SingleNumber;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenSearch_ThenResultAsExpected(int[] nums, int expectedResult)
    {
        var actualResult = Solution.SingleNumber(nums);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 2, 2, 1 }, 1];
        yield return [new[] { 4, 1, 2, 1, 2 }, 4];
        yield return [new[] { 10, 7, 5, 10, 5, 7, 9 }, 9];
        yield return [new[] { 1 }, 1];
    }
}
