using LeetCode.Challenges.ClimbingStairs.V1;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ClimbingStairs.V1;

public class RecursiveWithMemoSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNStepStaircase_WhenClimb_ThenResultAsExpected(int n, int expectedResult)
    {
        var actualResult = RecursiveWithMemoSolution.GetResult(n);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
