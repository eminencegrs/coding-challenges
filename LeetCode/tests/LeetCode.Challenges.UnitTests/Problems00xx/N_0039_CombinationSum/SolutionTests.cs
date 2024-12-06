using LeetCode.Challenges.Problems00xx.N_0039_CombinationSum;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0039_CombinationSum;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenCombinationSum_ThenResultAsExpected(
        int[] candidates, int target, IList<IList<int>> expectedResult)
    {
        Solution.CombinationSum(candidates, target).ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 2 }, 1, Enumerable.Empty<IList<int>>().ToList()];

        yield return
        [
            new[] { 2, 3, 6, 7 },
            7,
            new List<IList<int>>
            {
                new List<int> { 2, 2, 3 },
                new List<int> { 7 }
            }
        ];

        yield return
        [
            new[] { 2, 3, 5 },
            8,
            new List<IList<int>>
            {
                new List<int> { 2, 2, 2, 2 },
                new List<int> { 2, 3, 3 },
                new List<int> { 3, 5 }
            }
        ];
    }
}
