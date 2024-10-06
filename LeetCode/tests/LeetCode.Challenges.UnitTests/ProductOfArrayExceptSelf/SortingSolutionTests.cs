using LeetCode.Challenges.ProductOfArrayExceptSelf;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ProductOfArrayExceptSelf;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenContainsDuplicate_ThenResultAsExpected(int[] numbers, int[] expectedResult)
    {
        var actualResult = new Solution().ProductExceptSelf(numbers);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }
}
