using LeetCode.Challenges.Fibonacci;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Fibonacci;

public class RecursiveFibonacciTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumber_WhenGetResult_ThenResultAsExpected(int n, int expected)
    {
        RecursiveFibonacci.GetResult(n).ShouldBe(expected);
    }
}
