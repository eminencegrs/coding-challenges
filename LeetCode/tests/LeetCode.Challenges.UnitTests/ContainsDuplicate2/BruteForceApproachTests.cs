using LeetCode.Challenges.ContainsDuplicate2;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ContainsDuplicate2;

public class BruteForceApproachTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenContainsNearbyDuplicate_ThenResultAsExpected(int[] numbers, int k, bool expectedResult)
    {
        var actualResult = new BruteForceApproach().ContainsNearbyDuplicate(numbers, k);
        actualResult.ShouldBe(expectedResult);
    }
}