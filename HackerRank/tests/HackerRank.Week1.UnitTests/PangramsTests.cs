using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class PangramsTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenCallCheckIfPangramsV1_ThenResultAsExpected(string input, string expectedResult)
    {
        var sut = new Pangrams();
        var actualResult = sut.CheckIfPangramsV1(input);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[]
            {
                "We promptly judged antique ivory buckles for the next prize",
                "pangram"
            },
            new object[]
            {
                "We promptly judged antique ivory buckles for the prize",
                "not pangram"
            }
        };
}
