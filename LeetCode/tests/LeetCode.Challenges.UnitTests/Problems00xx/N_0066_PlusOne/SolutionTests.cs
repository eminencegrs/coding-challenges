using FluentAssertions;
using LeetCode.Challenges.Problems00xx.N_0066_PlusOne;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0066_PlusOne;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(NegativeTestCases))]
    public void GivenNumber_WhenPlusOne_ThenArgumentNullExceptionThrown(int[] nums)
    {
        var action = () => Solution.PlusOne(nums);
        action.Should().Throw<ArgumentNullException>();
    }

    [Theory]
    [MemberData(nameof(PositiveTestCases))]
    public void GivenNumber_WhenPlusOne_ThenResultAsExpected(int[] nums, int[] expectedResult)
    {
        var actualResult = Solution.PlusOne(nums);
        actualResult.SequenceEqual(expectedResult).ShouldBeTrue();
    }

    public static IEnumerable<object[]> NegativeTestCases()
    {
        yield return [null!];
        yield return [Array.Empty<int>()];
    }

    public static IEnumerable<object[]> PositiveTestCases()
    {
        yield return [new[] { 0 }, new[] { 1 }];
        yield return [new[] { 9 }, new[] { 1, 0 }];
        yield return [new[] { 1, 2, 3 }, new[] { 1, 2, 4 }];
        yield return [new[] { 8, 9, 9 }, new[] { 9, 0, 0 }];
        yield return [new[] { 9, 9, 9 }, new[] { 1, 0, 0, 0 }];
        yield return [new[] { 1, 9, 9, 9 }, new[] { 2, 0, 0, 0 }];
        yield return [new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 }];
        yield return [new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 1, 0, 0, 0, 0, 0, 0, 0 } ];
        yield return [new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 9 } ];
        yield return [new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 2 } ];
    }
}
