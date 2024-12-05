namespace LeetCode.Challenges.Problems00xx.N_0036_ValidSudoku;

public static class Solution
{
    private const int BoardSize = 9;

    public static bool IsValidSudoku(char[][] board)
    {
        var rows = new Dictionary<int, HashSet<int>>();
        var columns = new Dictionary<int, HashSet<int>>();
        var squares = new Dictionary<(int row, int column), HashSet<int>>();

        for (var i = 0; i < BoardSize; i++)
        {
            for (var j = 0; j < BoardSize; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }

                if (rows.TryGetValue(i, out var rItems))
                {
                    if (rItems.TryGetValue(board[i][j], out var _))
                    {
                        return false;
                    }

                    rItems.Add(board[i][j]);
                }
                else
                {
                    rows.Add(i, [board[i][j]]);
                }

                if (columns.TryGetValue(j, out var cItems))
                {
                    if (cItems.TryGetValue(board[i][j], out var _))
                    {
                        return false;
                    }

                    cItems.Add(board[i][j]);
                }
                else
                {
                    columns.Add(j, [board[i][j]]);
                }

                if (squares.TryGetValue((i / 3, j / 3), out var sItems))
                {
                    if (sItems.TryGetValue(board[i][j], out var _))
                    {
                        return false;
                    }

                    sItems.Add(board[i][j]);
                }
                else
                {
                    squares.Add((i / 3, j / 3), [board[i][j]]);
                }
            }
        }

        return true;
    }
}
