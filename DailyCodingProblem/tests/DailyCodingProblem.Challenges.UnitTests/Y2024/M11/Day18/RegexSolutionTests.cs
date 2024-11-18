using DailyCodingProblem.Challenges.Y2024.M11.Day18;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M11.Day18;

public class RegexSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenCheckIfNumber_ThenResultAsExpected(string input, bool expectedResult)
    {
        RegexSolution.CheckIfNumber(input).ShouldBe(expectedResult);
    }
}
