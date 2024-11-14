using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class TimeConversionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTimeIn12HourFormat_WhenCallConvert_ThenReturn24HourFormat(string input, string expectedResult)
    {
        TimeConversion.Convert(input).ShouldBeEquivalentTo(expectedResult);
    }

    [Theory]
    [MemberData(nameof(InvalidTestData))]
    public void GivenInvalidTimeFormat_WhenCallConvert_ThenThrowArgumentException(string input)
    {
        var action = () => TimeConversion.Convert(input);
        action.ShouldThrow<ArgumentException>();
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { "07:05:45PM", "19:05:45" },
            new object[] { "12:00:00PM", "12:00:00" },
            new object[] { "12:00:00AM", "00:00:00" },
            new object[] { "01:00:00AM", "01:00:00" },
            new object[] { "11:59:59PM", "23:59:59" },
            new object[] { "01:15:30PM", "13:15:30" }
        };

    public static IEnumerable<object[]> InvalidTestData =>
        new List<object[]>
        {
            new object[] { "24:00:00AM" },
            new object[] { "12:60:00PM" },
            new object[] { "12:00:60PM" },
            new object[] { "invalid input" },
            new object[] { "12:00PM" }
        };
}
