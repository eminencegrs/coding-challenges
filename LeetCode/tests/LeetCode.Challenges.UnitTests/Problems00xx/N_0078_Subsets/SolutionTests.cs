using FluentAssertions;
using LeetCode.Challenges.Problems00xx.N_0078_Subsets;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0078_Subsets;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenSubsets_ThenResultAsExpected(int[] numbers, IList<IList<int>> expectedResult)
    {
        Solution.Subsets(numbers).Should().BeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new[] { 1, 2, 3 },
            new List<IList<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 1, 2 },
                new List<int> { 1, 3 },
                new List<int> { 1 },
                new List<int> { 2, 3 },
                new List<int> { 2 },
                new List<int> { 3 },
                new List<int>()
            }
        ];

        yield return
        [
            new[] { 0 },
            new List<IList<int>>
            {
                new List<int> { 0 },
                new List<int>()
            }
        ];
    }
}
