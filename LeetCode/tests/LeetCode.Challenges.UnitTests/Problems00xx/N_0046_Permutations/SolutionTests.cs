using LeetCode.Challenges.Problems00xx.N_0046_Permutations;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0046_Permutations;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenPermute_ThenResultAsExpected(int[] numbers, IList<IList<int>> expectedResult)
    {
        Solution.Permute(numbers).ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 1, 2, 3 },
            new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 3, 2 },
                new List<int> { 2, 1, 3 },
                new List<int> { 2, 3, 1 },
                new List<int> { 3, 1, 2 },
                new List<int> { 3, 2, 1 }
            }
        ];

        yield return
        [
            new[] { 0, 1 },
            new List<IList<int>>
            {
                new List<int> { 0, 1 },
                new List<int> { 1, 0 }
            }
        ];

        yield return
        [
            new[] { 42 },
            new List<IList<int>>
            {
                new List<int> { 42 }
            }
        ];
    }
}
