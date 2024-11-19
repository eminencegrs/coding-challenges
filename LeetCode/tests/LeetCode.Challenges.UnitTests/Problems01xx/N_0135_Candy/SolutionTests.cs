using LeetCode.Challenges.Problems01xx.N_0135_Candy;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems01xx.N_0135_Candy;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenRatings_WhenSerialize_ThenStringAsExpected(int[] ratings, int expectedResult)
    {
        Solution.Candy(ratings).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [Array.Empty<int>(), 0];
        yield return [new[] { 1 }, 1];
        yield return [new[] { 1, 0, 2 }, 5];
        yield return [new[] { 1, 2, 2 }, 4];
        yield return [new[] { 1, 1, 1, 1 }, 4];
        yield return [new[] { 1, 3, 2, 4, 3 }, 7];
        yield return [new[] { 4, 3, 2, 1 }, 10];
        yield return [new[] { 2, 5, 8, 11 }, 10];
        yield return [new[] { 5, 4, 3, 5, 6, 2 }, 12];
        yield return [new[] { 1, 2, 3, 1, 0, 2, 4 }, 14];
    }
}
