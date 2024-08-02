using LeetCode.Challenges.NextPermutation;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.NextPermutation;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenNextPermutation_ThenResultAsExpected(int[] nums, int[] expectedResult)
    {
        new Solution().NextPermutation(nums);
        nums.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new [] { 1, 2, 3 }, new [] { 1, 3, 2 } ];
        yield return [ new [] { 1, 2, 4, 3 }, new [] { 1, 3, 2, 4 } ];
    }
}
