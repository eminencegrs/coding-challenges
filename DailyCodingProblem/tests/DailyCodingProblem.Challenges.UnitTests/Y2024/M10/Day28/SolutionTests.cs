using DailyCodingProblem.Challenges.Y2024.M10.Day28;
using FluentAssertions;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M10.Day28;

public class SolutionTests
{
    [Theory]
    [InlineData("figehaeci", "aei", "aeci")]
    [InlineData("figehaeci", "ae", "aeci")]
    [InlineData("figehaeci", "fi", "fig")]
    public void GivenChars_WhenMinWindow_ThenResultAsExpected(string input, string characters, string expected)
    {
        var result = new Solution().MinWindow(input, characters);
        result.Should().Be(expected);
    }

    [Fact]
    public void GivenCharsNotInInput_WhenMinWindow_ThenEmptyStringReturned()
    {
        const string input = "figehaeci";
        const string characters = "xyz";
        var result = new Solution().MinWindow(input, characters);
        result.Should().BeEmpty();
    }

    [Fact]
    public void GivenEmptyInput_WhenMinWindow_ThenEmptyStringReturned()
    {
        const string input = "";
        const string characters = "aei";
        var result = new Solution().MinWindow(input, characters);
        result.Should().BeEmpty();
    }

    [Fact]
    public void GivenEmptyCharSet_WhenMinWindow_ThenEmptyStringReturned()
    {
        const string input = "figehaeci";
        const string characters = "";
        var result = new Solution().MinWindow(input, characters);
        result.Should().BeEmpty();
    }

    [Fact]
    public void GivenSameInputAndCharSet_WhenMinWindow_ThenResultAsExpected()
    {
        const string input = "aei";
        const string characters = "aei";
        var result = new Solution().MinWindow(input, characters);
        result.Should().Be(input);
    }

    [Fact]
    public void GivenRepetitiveCharSet_WhenMinWindow_ThenResultAsExpected()
    {
        const string input = "aaabcab";
        const string characters = "abc";
        var result = new Solution().MinWindow(input, characters);
        result.Should().Be("abc");
    }
}
