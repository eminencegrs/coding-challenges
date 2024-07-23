using LeetCode.Challenges.Pow;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Pow;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenXandN_WhenCallGetResult_ThenResultAsExpected(double x, int n, double expectedResult)
    {
        var actualResult = Solution.GetResult(x, n);
        actualResult.ShouldBe(expectedResult);
    }
}
