using Xunit;
using DailyCodingProblem.Challenges.Y2024.M12.Day24;
using Shouldly;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M12.Day24;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GetFirstRecurringChar_ShouldReturnExpectedResult(string input, char? expected)
    {
        Solution.GetFirstRecurringChar(input).ShouldBe(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        return new List<object[]>
        {
            new object[] { "acbbac", 'b' },
            new object[] { "abcdef", null! },
            new object[] { "", null! },
            new object[] { "a", null! },
            new object[] { "aabbcc", 'a' },
            new object[] { "abcabc", 'a' },
            new object[] { "12345123", '1' },
            new object[] { null!, null! }
        };
    }
}
