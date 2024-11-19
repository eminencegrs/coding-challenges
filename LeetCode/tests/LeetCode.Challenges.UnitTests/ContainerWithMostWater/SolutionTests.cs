using LeetCode.Challenges.Problems00xx.N_0011_ContainerWithMostWater;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ContainerWithMostWater;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenHeights_WhenCallGetMaxArea_ThenResultAsExpected(int[] heights, int expectedResult)
    {
        var actualResult = TwoPointerSolution.GetMaxArea(heights);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49];
        yield return [new[] { 1, 1 }, 1];
    }
}
