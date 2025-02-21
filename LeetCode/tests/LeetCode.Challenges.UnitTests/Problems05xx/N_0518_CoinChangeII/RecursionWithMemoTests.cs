using LeetCode.Challenges.Problems05xx.N_0518_CoinChangeII;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems05xx.N_0518_CoinChangeII;

public class RecursionWithMemoTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenCoins_WhenCoinChange_ThenResultAsExpected(int amount, int[] coins, int expected)
    {
        RecursionWithMemo.Change(amount, coins).ShouldBe(expected);
    }
}
