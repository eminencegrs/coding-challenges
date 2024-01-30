using Shouldly;
using Xunit;

namespace HackerRank.Week1.UnitTests;

public class FlippingBitsTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumber_WhenCallFlipBits_ThenResultAsExpected(long number, long expectedResult)
    {
        var sut = new FlippingBits();
        var actualResult = sut.FlipBits(number);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData =>
        new List<object[]>
        {
            new object[] { 1, 4294967294 },
            new object[] { 2, 4294967293 },
            new object[] { 3, 4294967292 },
            new object[] { 4294967291, 4 },
            new object[] { 4294967290, 5 },
            new object[] { 4294967289, 6 }
        };
}
