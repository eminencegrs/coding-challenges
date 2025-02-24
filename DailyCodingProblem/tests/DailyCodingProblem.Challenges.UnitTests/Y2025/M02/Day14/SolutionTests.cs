using DailyCodingProblem.Challenges.Y2025.M02.Day14;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2025.M02.Day14;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenPositiveNumber_WhenVerifyCollatzSequence_ThenResultAsExpected(int n, bool expectedResult)
    {
        Solution.VerifyCollatzSequence(n).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [ 1, true ];
        yield return [ 2, true ];
        yield return [ 3, true ];
        yield return [ 4, true ];
        yield return [ 5, true ];
        yield return [ 6, true ];
        yield return [ 7, true ];
        yield return [ 8, true ];
        yield return [ 9, true ];
        yield return [ 10, true ];
    }
}
