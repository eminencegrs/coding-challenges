using LeetCode.Challenges.MedianOfTwoSortedArrays;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.MedianOfTwoSortedArrays;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArrays_WhenMerge_ThenResultAsExpected(int[] nums1, int[] nums2, double expectedResult)
    {
        var actualResult = new Solution().FindMedianSortedArrays(nums1, nums2);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new [] { 1, 3 },
            new [] { 2 },
            2.0
        ];
        yield return
        [
            new [] { 1, 2 },
            new [] { 3, 4 },
            2.5
        ];
        yield return
        [
            new [] { 1, 2, 3, 4, 5 },
            new [] { 6, 7, 8, 9 },
            5.0
        ];
        yield return
        [
            new [] { 2, 3, 4, 5 },
            new [] { 6, 7, 8, 9 },
            5.5
        ];
    }
}
