using LeetCode.Challenges.Problems02xx.N_0238_ProductOfArrayExceptSelf;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems02xx.N_0238_ProductOfArrayExceptSelf;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenProductExceptSelf_ThenResultAsExpected(int[] numbers, int[] expectedResult)
    {
        Solution.ProductExceptSelf(numbers).ShouldBeEquivalentTo(expectedResult);
    }
}
