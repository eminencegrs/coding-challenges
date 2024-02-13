using Xunit;
using LeetCode.Challenges.MergeSortedArray;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.MergeSortedArray;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArrays_WhenMerge_ThenResultAsExpected(int[] nums1, int[] nums2, int m, int n, int[] expectedResult)
    {
        new Solution().Merge(nums1, m, nums2, n);
        nums1.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new [] { 1, 2, 3, 0, 0, 0 },
            new [] { 2, 5, 6 },
            3,
            3,
            new [] { 1, 2, 2, 3, 5, 6 }
        ];
        yield return
        [
            new [] { 1 },
            Array.Empty<int>(),
            1,
            0,
            new [] { 1 }
        ];
        yield return
        [
            new [] { 0 },
            new [] { 1 },
            0,
            1,
            new [] { 1 }
        ];
    }
}
