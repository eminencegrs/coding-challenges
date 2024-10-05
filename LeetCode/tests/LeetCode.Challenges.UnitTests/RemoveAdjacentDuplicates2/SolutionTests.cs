using LeetCode.Challenges.RemoveAdjacentDuplicates2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.RemoveAdjacentDuplicates2;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenString_WhenRemoveDuplicates_ThenResultAsExpected(string str, int k, string expectedResult)
    {
        var actualResult = Solution.RemoveDuplicates(str, k);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
