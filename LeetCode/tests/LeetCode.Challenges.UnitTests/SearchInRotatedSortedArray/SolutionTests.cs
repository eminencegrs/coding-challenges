using LeetCode.Challenges.SearchInRotatedSortedArray;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.SearchInRotatedSortedArray;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArray_WhenSearch_ThenResultAsExpected(int[] nums, int target, int expectedResult)
    {
        var actualResult = Solution.Search(nums, target);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ new [] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4 ];
        yield return [ new [] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1 ];
        yield return [ new [] { 4, 5, 6, 7, 0, 1, 2 }, 7, 3 ];
        yield return [ new [] { 1 }, 0, -1 ];
    }
}
