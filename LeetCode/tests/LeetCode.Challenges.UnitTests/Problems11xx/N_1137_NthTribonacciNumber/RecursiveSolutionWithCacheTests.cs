using LeetCode.Challenges.Problems11xx.N_1137_NthTribonacciNumber;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems11xx.N_1137_NthTribonacciNumber;

public class RecursiveSolutionWithCacheTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumber_WhenRecursiveTribonacci_ThenResultAsExpected(int input, int expectedResult)
    {
        RecursiveSolutionWithCache.Tribonacci(input).ShouldBe(expectedResult);
    }
}
