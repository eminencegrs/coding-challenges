using LeetCode.Challenges.CoinChangeII;
using Xunit;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.CoinChangeII;

public class BacktrackingSolutionTests
{
    [Theory]
    [MemberData(nameof(CoinChangeTestCases))]
    public void GivenCoins_WhenCoinChange_ThenResultAsExpected(int[] coins, int amount, int expected)
    {
        BacktrackingSolution.CoinChange(coins, amount).ShouldBe(expected);
    }

    public static IEnumerable<object[]> CoinChangeTestCases()
    {
        //                      (5)
        //                    /    \
        //               -1 (4)     -2 (3)
        //              /    \         \
        //          -1 (3)   -2 (2)     -2 (1)
        //         /    \       |          |
        //     -1 (2)  -2 (0)   (0)        (X)
        //    /    \
        // -1 (1)  -2 (X)
        //  /
        // (0)
        // 
        // Valid Paths:
        // [1, 1, 1, 1, 1], [1, 1, 1, 2], [1, 2, 2]
        yield return [new[] { 1, 2 }, 5, 3];

        //                      (5)
        //                    /  |   \
        //               -1 (4) -2 (3) -5 (0)
        //              /  |        |
        //          -1 (3) -2 (2)  -2 (1)
        //         /  |        |      |
        //     -1 (2)-2 (0)    (0)    (X)
        //    /  |
        // -1 (1)-2 (X)
        //  /
        // (0)
        // 
        // Valid Paths:
        // [1, 1, 1, 1, 1], [1, 1, 1, 2], [1, 2, 2], [5]
        yield return [new[] { 1, 2, 5 }, 5, 4];

        yield return [new[] { 2 }, 3, 0];
        yield return [new[] { 1, 3, 4 }, 6, 4];
        yield return [new[] { 5 }, 5, 1];
        yield return [new[] { 5 }, 2, 0];
        yield return [new[] { 2, 5, 10 }, 1, 0];
        yield return [new[] { 10, 5 }, 20, 3];
        yield return [new[] { 1, 5, 10, 25 }, 30, 18];
        yield return [new[] { 2, 3 }, 7, 1];
        yield return [new[] { 1, 2, 5 }, 100, 541];
        yield return [new[] { 7, 3, 2 }, 8, 2];
        yield return [new[] { 1, 7, 10 }, 14, 4];
        yield return [new[] { 1, 3, 4, 7 }, 15, 22];
        yield return [new[] { 25, 50, 100 }, 30, 0];
        yield return [new[] { 9, 6, 5, 1 }, 11, 6];
    }
}
