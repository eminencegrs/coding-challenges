using LeetCode.Challenges.CoinChangeII;
using Xunit;
using Shouldly;

namespace LeetCode.Challenges.UnitTests.CoinChangeII;

public class BacktrackingSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenCoins_WhenCoinChange_ThenResultAsExpected(int amount, int[] coins, int expected)
    {
        BacktrackingSolution.CoinChange(amount, coins).ShouldBe(expected);
    }
}