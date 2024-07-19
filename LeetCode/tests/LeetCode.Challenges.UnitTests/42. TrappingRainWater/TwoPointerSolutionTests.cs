using LeetCode.Challenges.TrappingRainWater;
using Shouldly;
using Xunit;

// ReSharper disable once CheckNamespace
namespace LeetCode.Challenges.UnitTests.TrappingRainWater;

public class TwoPointerSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenHeights_WhenCallGetResult_ThenResultAsExpected(int[] heights, int expectedResult)
    {
        var actualResult = TwoPointerSolution.GetResult(heights);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
