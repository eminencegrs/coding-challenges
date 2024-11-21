using LeetCode.Challenges.Problems00xx.N_0013_RomanToInteger;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0013_RomanToInteger;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenRomanToInt_ThenResultAsExpected(string input, int expectedResult)
    {
        Solution.RomanToInt(input).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // Single numeral cases.
        yield return ["I", 1];
        yield return ["V", 5];
        yield return ["X", 10];
        yield return ["L", 50];
        yield return ["C", 100];
        yield return ["D", 500];
        yield return ["M", 1000];

        // Simple addition cases.
        yield return ["II", 2];
        yield return ["III", 3];
        yield return ["VI", 6];
        yield return ["XI", 11];
        yield return ["XV", 15];
        yield return ["XX", 20];
        yield return ["XXX", 30];
        yield return ["LX", 60];
        yield return ["CL", 150];
        yield return ["MM", 2000];

        // Subtractive notation cases.
        yield return ["IV", 4];
        yield return ["IX", 9];
        yield return ["XL", 40];
        yield return ["XC", 90];
        yield return ["CD", 400];
        yield return ["CM", 900];

        // Complex combinations.
        yield return ["XLII", 42];
        yield return ["LVIII", 58];
        yield return ["XCIV", 94];
        yield return ["CDLXIX", 469];
        yield return ["CDXC", 490];
        yield return ["DCCLXXIV", 774];
        yield return ["CMXC", 990];
        yield return ["MCMXCIV", 1994];
        yield return ["MMMDCCXLIX", 3749];
        yield return ["MMMCMXCIX", 3999];
    }
}
