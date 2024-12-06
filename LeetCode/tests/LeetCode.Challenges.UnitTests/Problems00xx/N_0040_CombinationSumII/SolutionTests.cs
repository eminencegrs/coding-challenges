using LeetCode.Challenges.Problems00xx.N_0040_CombinationSumII;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0040_CombinationSumII;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenCombinationSum2_ThenResultAsExpected(
        int[] candidates, int target, IList<IList<int>> expectedResult)
    {
        Solution.CombinationSum2(candidates, target).ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 2 }, 1, Enumerable.Empty<IList<int>>().ToList()];

        yield return
        [
            new[] { 10, 1, 2, 7, 6, 1, 5 },
            8,
            new List<IList<int>>
            {
                new List<int> { 1, 1, 6 },
                new List<int> { 1, 2, 5 },
                new List<int> { 1, 7 },
                new List<int> { 2, 6 }
            }
        ];

        yield return
        [
            new[] { 2, 5, 2, 1, 2 },
            5,
            new List<IList<int>>
            {
                new List<int> { 1, 2, 2 },
                new List<int> { 5 }
            }
        ];
    }
}
