using LeetCode.Challenges.ContainsDuplicate;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ContainsDuplicate;

public class SortingSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenContainsDuplicate_ThenResultAsExpected(int[] numbers, bool expectedResult)
    {
        var actualResult = new SortingSolution().ContainsDuplicate(numbers);
        actualResult.ShouldBe(expectedResult);
    }
}
