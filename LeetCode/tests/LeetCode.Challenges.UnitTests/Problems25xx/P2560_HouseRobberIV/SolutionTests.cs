using LeetCode.Challenges.Problems25xx.P2560_HouseRobberIV;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems25xx.P2560_HouseRobberIV;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenMinCapability_ThenResultAsExpected(int[] numbers, int k, int expectedResult)
    {
        Solution.MinCapability(numbers, k).ShouldBe(expectedResult);
    }
}
