using FluentAssertions;
using LeetCode.Challenges.Problems05xx.N_0506_RelativeRanks;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems05xx.N_0506_RelativeRanks;

public class MaxHeapSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenScores_WhenFindRelativeRanks_ThenResultAsExpected(
        int[] scores, string[] expectedResult)
    {
        MaxHeapSolution.FindRelativeRanks(scores).Should().BeEquivalentTo(expectedResult);
    }
}
