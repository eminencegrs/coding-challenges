using System;
using System.Text;
using System.Threading;
using FluentAssertions;
using LeetCode.Challenges.PrintInOrder;
using Xunit;

namespace LeetCode.Challenges.UnitTests.PrintInOrder;

public class SemaphoreSlimSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenOrder_WhenRunThreeMethods_ThenMethodsExecutedInOrderRegardlessOfInvocation(int[] nums)
    {
        using var cut = new SemaphoreSlimSolution();
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

    [Fact]
    public void GivenDisposedObject_WhenRunAnyMethod_ThenObjectDisposedExceptionThrown()
    {
        var cut = new SemaphoreSlimSolution();
        cut.Dispose();
        Action action = () => cut.First(() => Console.WriteLine("blah"));
        action.Should().Throw<ObjectDisposedException>();
    }
}
