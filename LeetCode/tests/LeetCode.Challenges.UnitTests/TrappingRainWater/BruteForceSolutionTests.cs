using LeetCode.Challenges.TrappingRainWater;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TrappingRainWater;

public class BruteForceSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenHeights_WhenCallGetResult_ThenResultAsExpected(int[] heights, int expectedResult)
    {
        var actualResult = BruteForceSolution.GetResult(heights);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
