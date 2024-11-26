using LeetCode.Challenges.Problems12xx.N_1209_RemoveAllAdjacentDuplicatesInStringII;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems12xx.N_1209_RemoveAllAdjacentDuplicatesInStringII;

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
