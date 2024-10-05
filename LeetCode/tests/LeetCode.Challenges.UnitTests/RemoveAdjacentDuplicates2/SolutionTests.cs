using LeetCode.Challenges.RemoveAdjacentDuplicates2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.RemoveAdjacentDuplicates2;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenCallGetResult_ThenResultAsExpected(string input, int k, string expectedResult)
    {
        var actualResult = Solution.RemoveDuplicates(input, k);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
