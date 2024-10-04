using LeetCode.Challenges.BasicCalculator2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.BasicCalculator2;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenExpression_WhenCalculate_ThenResultAsExpected(string input, int expectedResult)
    {
        var actualResult = new Solution().Calculate(input);
        actualResult.ShouldBe(expectedResult);
    }
}
