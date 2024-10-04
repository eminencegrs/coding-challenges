using LeetCode.Challenges.Tribonacci;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Tribonacci;

public class RecursiveSolutionWithCacheTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenReverse_ThenResultAsExpected(int input, int expectedResult)
    {
        var actualResult = new RecursiveSolutionWithCache().Tribonacci(input);
        actualResult.ShouldBe(expectedResult);
    }
}
