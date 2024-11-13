using LeetCode.Challenges.Problems17xx.P1791_FindCenterOfStarGraph;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems17xx.P1791_FindCenterOfStarGraph;

public class TheBestSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenStarGraph_WhenFindCenter_ThenResultAsExpected(int[][] edges, int expectedResult)
    {
        TheBestSolution.FindCenter(edges).ShouldBe(expectedResult);
    }
}
