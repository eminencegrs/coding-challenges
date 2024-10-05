using LeetCode.Challenges.SingleNumber2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.SingleNumber2;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenSearch_ThenResultAsExpected(int[] nums, int expectedResult)
    {
        var actualResult = SingleNumber2Solution.Get(nums);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 2, 2, 2, 3 }, 3];
        yield return [new[] { 0, 1, 0, 1, 0, 1, 99 }, 99];
    }
}
