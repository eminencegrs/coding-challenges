using LeetCode.Challenges.ValidParentheses;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ValidParentheses;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenParentheses_WhenIsValid_ThenResultAsExpected(string input, bool expectedResult)
    {
        Solution.IsValid(input).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return ["()", true];
        yield return ["[]", true];
        yield return ["{}", true];
        yield return ["(]", false];
        yield return ["([)]", false];
        yield return ["([])", true];
        yield return ["{[()]}", true];
        yield return ["{[(])}", false];
        yield return ["", true];
        yield return ["[({})]{}", true];
        yield return ["[", false];
        yield return [")", false];
        yield return ["{[", false];
        yield return ["{[]})", false];
        yield return ["([{}])", true];
        yield return ["[{()}([])]", true];
        yield return ["[{()](})", false];
        yield return ["[({}{}{})({[]})]", true];
        yield return ["{[()]}[()]{}{()}", true];
        yield return ["((((((((()))))))))", true];
    }
}
