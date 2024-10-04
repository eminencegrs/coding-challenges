using Xunit;
using LeetCode.Challenges.Tribonacci;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.Tribonacci;

public class IterativeSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenReverse_ThenResultAsExpected(int input, int expectedResult)
    {
        var actualResult = new IterativeSolution().Tribonacci(input);
        actualResult.ShouldBe(expectedResult);
    }
}
