using DailyCodingProblem.Challenges.Y2024.M10.Day7;
using FluentAssertions;
using FluentAssertions.Execution;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M10.Day7;

public class ReaderNTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenReadN_ThenResultAsExpected(
        string content, int n, char[] expectedOutput, int expectedReadCount)
    {
        var reader = new ReaderN(content);
        var actualOutput = new char[n];

        var actualReadCount = reader.ReadN(actualOutput, n);

        using (new AssertionScope())
        {
            actualOutput.Should().BeEquivalentTo(expectedOutput);
            actualReadCount.Should().Be(expectedReadCount);
        }
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return ["This is a test string content.", 5, "This ".ToCharArray(), 5];
        yield return ["This is a test string content.", 32, "This is a test string content.\0\0".ToCharArray(), 30];
    }

    [Fact]
    public void GivenString_WhenReadNManyTimes_ThenResultAsExpected()
    {
        const string content = "This is a test string content.";
        const int n = 7;

        var reader = new ReaderN(content);
        var actualOutput = new char[n];

        var actualReadCount = reader.ReadN(actualOutput, n);
        ConvertCharsToString(actualOutput).Should().BeEquivalentTo("This is");
        actualOutput = new char[n];

        actualReadCount = reader.ReadN(actualOutput, n);
        ConvertCharsToString(actualOutput).Should().BeEquivalentTo(" a test");
        actualOutput = new char[n];

        actualReadCount = reader.ReadN(actualOutput, n);
        ConvertCharsToString(actualOutput).Should().BeEquivalentTo(" string");
        actualOutput = new char[n];

        actualReadCount = reader.ReadN(actualOutput, n);
        ConvertCharsToString(actualOutput).Should().BeEquivalentTo(" conten");
        actualOutput = new char[n];

        actualReadCount = reader.ReadN(actualOutput, n);
        ConvertCharsToString(actualOutput).Should().BeEquivalentTo("t.");
    }

    private static string ConvertCharsToString(char[] chars, bool isNullIgnored = true) =>
        isNullIgnored ? new string(chars.Where(c => c != '\0').ToArray()) : new string(chars);
}
