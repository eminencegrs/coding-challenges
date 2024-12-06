using LeetCode.Challenges.Problems25xx.N_2554_MaximumNumberOfIntegersToChooseFromRangeI;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems25xx.N_2554_MaximumNumberOfIntegersToChooseFromRangeI;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenMaxCount_ThenResultAsExpected(
        int[] banned, int n, int maxSum, int expectedResult)
    {
        GreedyApproach.MaxCount(banned, n, maxSum).ShouldBeEquivalentTo(expectedResult);
    }
}
