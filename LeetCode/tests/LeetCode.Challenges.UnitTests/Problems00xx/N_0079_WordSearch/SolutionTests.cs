using LeetCode.Challenges.Problems00xx.N_0079_WordSearch;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0079_WordSearch;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenSubsets_ThenResultAsExpected(char[][] board, string word, bool expectedResult)
    {
        Solution.Exist(board, word).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "ABCCED",
            true
        ];

        yield return
        [
            new char[][]
            {
                ['A', 'B', 'C', 'E'],
                ['S', 'F', 'C', 'S'],
                ['A', 'D', 'E', 'E']
            },
            "SEE",
            true
        ];

        yield return
        [
            new char[][]
            {
                [ 'A', 'B', 'C', 'E' ],
                [ 'S', 'F', 'C', 'S' ],
                [ 'A', 'D', 'E', 'E' ]
            },
            "ABCB",
            false
        ];
    }
}
