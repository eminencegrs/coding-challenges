using FluentAssertions;
using LeetCode.Challenges.SingleNumber3;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.SingleNumber3;

public class SingleNumber3SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenSearch_ThenResultAsExpected(int[] nums, int[] expectedResult)
    {
        var actualResult = SingleNumber3Solution.Get(nums);
        actualResult.Should().BeEquivalentTo(expectedResult);

        // TODO: research is needed.
        // The current assertion method (ShouldBeEquivalentTo) fails because it checks for exact order.
        // actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 1, 2, 1, 3, 2, 5 }, new[] { 3, 5 }];
        yield return [new[] { 1, 2, 1, 3, 2, 5 }, new[] { 5, 3 }];
        yield return [new[] { -1, 0 }, new[] { -1, 0 }];
        yield return [new[] { 0, 1 }, new[] { 0, 1 }];
    }
}
