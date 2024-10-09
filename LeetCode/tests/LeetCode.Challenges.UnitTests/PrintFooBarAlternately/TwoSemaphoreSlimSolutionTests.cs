using System.Text;
using FluentAssertions;
using LeetCode.Challenges.PrintFooBarAlternately;
using Xunit;

namespace LeetCode.Challenges.UnitTests.PrintFooBarAlternately;

// ReSharper disable AccessToDisposedClosure
public class TwoSemaphoreSlimSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public async Task FooBar_Should_AlternateBetweenFooAndBar(int number, string expectedOutput)
    {
        var cut = new TwoSemaphoreSlimSolution(number);
        var output = new StringBuilder();
        Action printFoo = () => output.Append("foo");
        Action printBar = () => output.Append("bar");

        try
        {
            var fooTask = Task.Run(() => cut.Foo(printFoo));
            var barTask = Task.Run(() => cut.Bar(printBar));

            await Task.WhenAll(fooTask, barTask);

            output.ToString().Should().BeEquivalentTo(expectedOutput);
        }
        finally
        {
            cut.Dispose();
        }
    }
}
