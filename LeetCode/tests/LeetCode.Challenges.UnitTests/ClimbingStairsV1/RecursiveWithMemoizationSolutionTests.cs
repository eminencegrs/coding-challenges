using LeetCode.Challenges.ClimbingStairsV1;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ClimbingStairsV1;

public class RecursiveWithMemoizationSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNStepStaircase_WhenClimb_ThenResultAsExpected(int n, int expectedResult)
    {
        var actualResult = RecursiveWithMemoizationSolution.GetResult(n);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
