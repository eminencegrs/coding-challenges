using Xunit;
using LeetCode.Challenges.Tribonacci;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.Tribonacci;

public class IterativeSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumber_WhenCallIterativeTribonacci_ThenResultAsExpected(int input, int expectedResult)
    {
        var actualResult = new IterativeSolution().Tribonacci(input);
        actualResult.ShouldBe(expectedResult);
    }
}
