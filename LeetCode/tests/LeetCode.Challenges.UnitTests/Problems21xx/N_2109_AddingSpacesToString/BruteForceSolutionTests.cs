using LeetCode.Challenges.Problems21xx.N_2109_AddingSpacesToString;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems21xx.N_2109_AddingSpacesToString;

public class BruteForceSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenStringAndSpaces_WhenMinCapability_ThenResultAsExpected(
        string input, int[] spaces, string expectedResult)
    {
        BruteForceSolution.AddSpaces(input, spaces).ShouldBeEquivalentTo(expectedResult);
    }
}
