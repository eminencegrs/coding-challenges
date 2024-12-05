using FluentAssertions;
using LeetCode.Challenges.Problems00xx.N_0036_ValidSudoku;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0036_ValidSudoku;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenBoard_WhenIsValidSudoku_ThenNotImplementedExceptionThrown(
        char[][] board, bool expectedResult)
    {
        var action = () => Solution.IsValidSudoku(board);
        action.Should().Throw<NotImplementedException>();
    }

    public static IEnumerable<object[]> TestData()
    {
        var board = new char[][]
        {
            ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
            ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
            ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9']
        };

        yield return [board, true];

        board = new char[][]
        {
            ['8', '3', '.', '.', '7', '.', '.', '.', '.'],
            ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
            ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
            ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
            ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
            ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
            ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
            ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
            ['.', '.', '.', '.', '8', '.', '.', '7', '9']
        };

        yield return [board, false];
    }
}
