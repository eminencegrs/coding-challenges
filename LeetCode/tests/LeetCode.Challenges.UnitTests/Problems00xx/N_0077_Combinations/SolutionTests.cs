using FluentAssertions;
using LeetCode.Challenges.Problems00xx.N_0077_Combinations;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0077_Combinations;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestCases))]
    public void GivenNandK_WhenCombine_ThenResultAsExpected(int n, int k, List<List<int>> expectedResult)
    {
        Solution.Combine(n, k).Should().BeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestCases()
    {
        yield return [1, 1, new List<List<int>> { new() { 1 } }];

        yield return [2, 2, new List<List<int>> { new() { 1, 2 } }];

        yield return [4, 1, new List<List<int>> { new() { 1 }, new() { 2 }, new() { 3 }, new() { 4 } }];

        yield return
        [
            4,
            2, 
            new List<List<int>>
            {
                new() { 1, 2 }, new() { 1, 3 }, new() { 1, 4 },
                new() { 2, 3 }, new() { 2, 4 }, new() { 3, 4 }
            }
        ];

        yield return [4, 4, new List<List<int>> { new() { 1, 2, 3, 4 } }];

        yield return
        [
            5, 
            3, 
            new List<List<int>>
            {
                new() { 1, 2, 3 }, new() { 1, 2, 4 },
                new() { 1, 2, 5 }, new() { 1, 3, 4 },
                new() { 1, 3, 5 }, new() { 1, 4, 5 },
                new() { 2, 3, 4 }, new() { 2, 3, 5 },
                new() { 2, 4, 5 }, new() { 3, 4, 5 }
            }
        ];

        yield return [5, 5, new List<List<int>> { new() { 1, 2, 3, 4, 5 } }];

        yield return
        [
            6, 
            2, 
            new List<List<int>> 
            {
                new() { 1, 2 }, new() { 1, 3 }, new() { 1, 4 }, new() { 1, 5 }, new() { 1, 6 },
                new() { 2, 3 }, new() { 2, 4 }, new() { 2, 5 }, new() { 2, 6 }, new() { 3, 4 },
                new() { 3, 5 }, new() { 3, 6 }, new() { 4, 5 }, new() { 4, 6 }, new() { 5, 6 }
            }
        ];

        yield return
        [
            20, 
            1, 
            new List<List<int>> 
            { 
                new() { 1 }, new() { 2 }, new() { 3 }, new() { 4 }, new() { 5 },
                new() { 6 }, new() { 7 }, new() { 8 }, new() { 9 }, new() { 10 },
                new() { 11 }, new() { 12 }, new() { 13 }, new() { 14 }, new() { 15 },
                new() { 16 }, new() { 17 }, new() { 18 }, new() { 19 }, new() { 20 }
            }
        ];
    }
}
