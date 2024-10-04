using LeetCode.Challenges.Tribonacci;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Tribonacci;

public class RecursiveSolutionWithCacheTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumber_WhenRecursiveTribonacci_ThenResultAsExpected(int input, int expectedResult)
    {
        var actualResult = new RecursiveSolutionWithCache().Tribonacci(input);
        actualResult.ShouldBe(expectedResult);
    }
}
