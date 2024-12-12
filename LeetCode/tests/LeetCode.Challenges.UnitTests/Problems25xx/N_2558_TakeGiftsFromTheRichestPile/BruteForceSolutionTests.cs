using LeetCode.Challenges.Problems25xx.N_2558_TakeGiftsFromTheRichestPile;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems25xx.N_2558_TakeGiftsFromTheRichestPile;

public class BruteForceSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenGifts_WhenMinPickGifts_ThenResultAsExpected(int[] numbers, int k, long expectedResult)
    {
        BruteForceSolution.PickGifts(numbers, k).ShouldBe(expectedResult);
    }
}
