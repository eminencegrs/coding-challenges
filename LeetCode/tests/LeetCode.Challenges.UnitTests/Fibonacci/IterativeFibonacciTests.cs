using LeetCode.Challenges.Fibonacci;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Fibonacci;

public class IterativeFibonacciTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumber_WhenGetResult_ThenResultAsExpected(int n, int expected)
    {
        IterativeFibonacci.GetResult(n).ShouldBe(expected);
    }
}
