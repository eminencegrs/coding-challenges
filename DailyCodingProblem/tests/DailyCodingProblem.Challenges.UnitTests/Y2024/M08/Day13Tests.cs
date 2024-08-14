using DailyCodingProblem.Challenges.Y2024.M08;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M08;

public class Day18Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenBrackets_WhenCheckIfBalanced_ThenResultAsExpected(string brackets, bool expectedResult)
    {
        bool actualResult = Day13Task.CheckIfBalanced(brackets);
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
