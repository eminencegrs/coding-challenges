using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class XorStringsTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTwoStrings_WhenCallProcess_ThenResultAsExpected(
        string first, string second, string expectedResult)
    {
        var sut = new XorStrings();
        var actualResult = sut.Process(first, second);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { "10101", "00101", "10000" },
            new object[] { "11111111", "00000000", "11111111" },
            new object[] { "11111111", "11111111", "00000000" },
            new object[] { "10101010", "01010101", "11111111" }
        };
}
