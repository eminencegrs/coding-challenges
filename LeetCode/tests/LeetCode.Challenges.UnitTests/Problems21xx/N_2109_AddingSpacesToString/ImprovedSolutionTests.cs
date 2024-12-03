using LeetCode.Challenges.Problems21xx.N_2109_AddingSpacesToString;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems21xx.N_2109_AddingSpacesToString;

public class ImprovedSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenStringAndSpaces_WhenMinCapability_ThenResultAsExpected(
        string input, int[] spaces, string expectedResult)
    {
        ImprovedSolution.AddSpaces(input, spaces).ShouldBeEquivalentTo(expectedResult);
    }
}
