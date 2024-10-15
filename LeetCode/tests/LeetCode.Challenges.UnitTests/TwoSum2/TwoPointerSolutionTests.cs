using LeetCode.Challenges.TwoSum2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TwoSum2;

public class TwoPointerSolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenGetResult_ThenResultAsExpected(int[] nums, int target, int[] expectedResult)
    {
        var result = TwoPointerSolution.GetResult(nums, target);
        result.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new [] { 2, 7, 11, 15 }, 9, new [] { 1, 2 } ];
        yield return [ new [] { 2, 3, 4 }, 6, new [] { 1, 3 } ];
        yield return [ new [] { -1, 0 }, -1, new [] { 1, 2 } ];
        yield return [ new [] { -9, -7, -5, -3, 0, 2, 4, 5, 8, 10  }, 0, new [] { 3, 8 } ];
    }
}
