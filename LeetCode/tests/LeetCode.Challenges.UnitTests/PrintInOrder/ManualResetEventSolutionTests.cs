using System.Text;
using FluentAssertions;
using LeetCode.Challenges.PrintInOrder;
using Xunit;

namespace LeetCode.Challenges.UnitTests.PrintInOrder;

public class ManualResetEventSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenOrder_WhenRunThreeMethods_ThenMethodsExecutedInOrderRegardlessOfInvocation(int[] nums)
    {
        using var cut = new ManualResetEventSolution();
        var output = new StringBuilder();

        Action printFirst = () => output.Append("first");
        Action printSecond = () => output.Append("second");
        Action printThird = () => output.Append("third");

        var threads = new Thread[nums.Length];
        for (int i = 0; i < 3; i++)
        {
            threads[i] = nums[i] switch
            {
                1 => new Thread(() => cut.First(printFirst)),
                2 => new Thread(() => cut.Second(printSecond)),
                3 => new Thread(() => cut.Third(printThird)),
                _ => throw new ArgumentException("Invalid input")
            };
        }

        foreach (var thread in threads)
        {
            thread.Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        output.ToString().Should().Be("firstsecondthird");
    }
}
