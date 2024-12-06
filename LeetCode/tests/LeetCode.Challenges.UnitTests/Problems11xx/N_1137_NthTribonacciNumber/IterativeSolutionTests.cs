using LeetCode.Challenges.Problems11xx.N_1137_NthTribonacciNumber;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems11xx.N_1137_NthTribonacciNumber;

public class IterativeSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumber_WhenCallIterativeTribonacci_ThenResultAsExpected(int input, int expectedResult)
    {
        IterativeSolution.Tribonacci(input).ShouldBe(expectedResult);
    }
}
