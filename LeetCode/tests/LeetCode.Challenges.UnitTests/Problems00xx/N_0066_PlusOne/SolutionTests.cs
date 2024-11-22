using LeetCode.Challenges.Problems00xx.N_0066_PlusOne;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0066_PlusOne;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenNextPermutation_ThenResultAsExpected(int[] nums, int[] expectedResult)
    {
        var actualResult = Solution.PlusOne(nums);
        actualResult.SequenceEqual(expectedResult).ShouldBeTrue();
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 0 }, new[] { 1 }];
        yield return [new[] { 9 }, new[] { 1, 0 }];
        yield return [new[] { 1, 2, 3 }, new[] { 1, 2, 4 }];
        yield return [new[] { 8, 9, 9 }, new[] { 9, 0, 0 }];
        yield return [new[] { 9, 9, 9 }, new[] { 1, 0, 0, 0 }];
        yield return [new[] { 1, 9, 9, 9 }, new[] { 2, 0, 0, 0 }];
        yield return [new[] { 4, 3, 2, 1 }, new[] { 4, 3, 2, 2 }];
    }
}
