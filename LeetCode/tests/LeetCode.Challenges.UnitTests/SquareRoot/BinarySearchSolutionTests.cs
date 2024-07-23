using LeetCode.Challenges.SquareRoot;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.SquareRoot;

public class BinarySearchSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenX_WhenCallGetResult_ThenResultAsExpected(int x, int expectedResult)
    {
        var actualResult = BinarySearchSolution.GetResult(x);
        actualResult.ShouldBe(expectedResult);
    }
}
