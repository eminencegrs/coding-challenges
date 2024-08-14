using DailyCodingProblem.Challenges.Year2024.Month08August;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Year2024.Month08August;

public class Day18Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenBrackets_WhenCheckIfBalanced_ThenResultAsExpected(string brackets, bool expectedResult)
    {
        bool actualResult = Day13.CheckIfBalanced(brackets);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ "()", true ];
        yield return [ ")(", false ];
        yield return [ "[]", true ];
        yield return [ "][", false ];
        yield return [ "{}", true ];
        yield return [ "}{", false ];
        yield return [ "()[]{}", true ];
        yield return [ "[]{}()", true ];
        yield return [ "{}()[]", true ];
        yield return [ "([{}])", true ];
        yield return [ "([{([{}])}])", true ];
        yield return [ "([])[{}]{()}", true ];
        yield return [ "{[()]}([{}])", true ];
        yield return [ ")[()]", false ];
        yield return [ "([])[", false ];
        yield return [ "(}[)", false ];
        yield return [ "((()", false ];
        yield return [ "()))", false ];
        yield return [ "[[[[[[[[[[]]]]]]]]]", false ];
        yield return [ "{{{{{{{{{}}}}}}}}}}", false ];
    }
}
