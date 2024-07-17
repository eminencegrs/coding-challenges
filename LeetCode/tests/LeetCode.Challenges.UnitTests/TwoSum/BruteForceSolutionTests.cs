using LeetCode.Challenges.TwoSum;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TwoSum;

public class BruteForceSolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenGetResult_ThenResultAsExpected(int[] nums, int target, int[] expectedResult)
    {
        int[] result = BruteForceSolution.GetResult(nums, target);
        result.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new [] { 2, 7, 11, 15 }, 9, new [] { 0, 1 } ];
        yield return [ new [] { 3, 2, 4 }, 6, new [] { 1, 2 } ];
        yield return [ new [] { 3, 3 }, 6, new [] { 0, 1 } ];
    }
}
