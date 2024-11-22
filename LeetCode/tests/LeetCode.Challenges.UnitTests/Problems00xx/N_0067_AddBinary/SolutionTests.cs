using FluentAssertions;
using LeetCode.Challenges.Problems00xx.N_0067_AddBinary;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0067_AddBinary;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(PositiveTestCases))]
    public void GivenNumbersInBinary_WhenAddBinary_ThenResultAsExpected(string a, string b, string expectedResult)
    {
        Solution.AddBinary(a, b).ShouldBeEquivalentTo(expectedResult);
    }

    [Theory]
    [MemberData(nameof(NegativeTestCases))]
    public void GivenInvalidInput_WhenAddBinary_ThenExceptionThrown(string a, string b)
    {
        var action = () => Solution.AddBinary(a, b);
        action.Should().Throw<ArgumentException>();
    }

    public static IEnumerable<object[]> PositiveTestCases()
    {
        yield return ["0", "0", "0"];
        yield return ["1", "0", "1"];
        yield return ["0", "1", "1"];
        yield return ["1", "1", "10"];
        yield return ["101", "11", "1000"];
        yield return ["11", "101", "1000"];
        yield return ["1000", "1", "1001"];
        yield return ["1", "1000", "1001"];
        yield return ["111", "1", "1000"];
        yield return ["111", "111", "1110"];
        yield return ["101010", "1011", "110101"];
        yield return ["1101101", "1010101", "11000010"];
        yield return ["11111110", "1", "11111111"];
    }

    public static IEnumerable<object[]> NegativeTestCases()
    {
        yield return ["", ""];
        yield return ["1", ""];
        yield return ["", "1"];
        yield return [null!, null!];
        yield return ["1", null!];
        yield return [null!, "1"];
    }
}
