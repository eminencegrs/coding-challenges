using LeetCode.Challenges.Problems00xx.N_0036_ValidSudoku;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0036_ValidSudoku;

public class SolutionV1Tests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenBoard_WhenIsValidSudoku_ThenResultAsExpected(char[][] board, bool expectedResult)
    {
        SolutionV1.IsValidSudoku(board).ShouldBe(expectedResult);
    }
}
