using LeetCode.Challenges.SquareRoot;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.SquareRoot;

public class NewtonsMethodTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenX_WhenCallGetResult_ThenResultAsExpected(int x, int expectedResult)
    {
        var actualResult = NewtonsMethod.GetResult(x);
        actualResult.ShouldBe(expectedResult);
    }
}
