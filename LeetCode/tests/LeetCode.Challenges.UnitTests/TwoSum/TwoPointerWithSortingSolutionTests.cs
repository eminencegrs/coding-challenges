using LeetCode.Challenges.TwoSum;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TwoSum;

public class TwoPointerWithSortingSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenArray_WhenGetResult_ThenResultAsExpected(int[] nums, int target, int[] expectedResult)
    {
        int[] result = TwoPointerWithSortingSolution.GetResult(nums, target);
        result.ShouldBeEquivalentTo(expectedResult);
    }
}
