using LeetCode.Challenges.CoinChange;
using Xunit;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.CoinChange;

public class SolutionV2Tests
{
    [Theory]
    [MemberData(nameof(CoinChangeTestCases))]
    public void CoinChange_ShouldReturnExpectedResult(int[] coins, int amount, int expected)
    {
        SolutionV2.CoinChange(coins, amount).ShouldBe(expected);
    }

    public static IEnumerable<object[]> CoinChangeTestCases()
    {
        yield return [new[] { 1, 2, 5 }, 11, 3];
        yield return [new[] { 2 }, 3, -1];
        yield return [new[] { 1 }, 0, 0];
        yield return [new[] { 186, 419, 83, 408 }, 6249, 20];
        yield return [new[] { 1, 3, 4 }, 6, 2];
        yield return [new[] { 5 }, 5, 1];
        yield return [new[] { 5 }, 0, 0];
        yield return [new[] { 5 }, 2, -1];
        yield return [new[] { 2, 5, 10 }, 1, -1];
        yield return [new[] { 10, 5 }, 20, 2];
        yield return [new[] { 1, 5, 10, 25 }, 30, 2];
        yield return [new[] { 2, 3 }, 7, 3];
        yield return [new[] { 1, 2, 5 }, 100, 20];
        yield return [new[] { 7, 3, 2 }, 8, 3];
        yield return [new[] { 1, 7, 10 }, 14, 2];
        yield return [new[] { 1, 3, 4, 7 }, 15, 3];
        yield return [new[] { 25, 50, 100 }, 30, -1];
        yield return [new[] { 9, 6, 5, 1 }, 11, 2];
    }
}
