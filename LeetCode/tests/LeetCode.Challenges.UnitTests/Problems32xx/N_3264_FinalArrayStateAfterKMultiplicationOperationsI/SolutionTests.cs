using FluentAssertions;
using LeetCode.Challenges.Problems32xx.N_3264_FinalArrayStateAfterKMultiplicationOperationsI;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems32xx.N_3264_FinalArrayStateAfterKMultiplicationOperationsI;

public class MaxHeapSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbersAndMultiplier_WhenGetFinalState_ThenResultAsExpected(
        int[] numbers, int k, int multiplier, int[] expectedResult)
    {
        Solution.GetFinalState(numbers, k, multiplier).Should().BeEquivalentTo(expectedResult);
    }
}
