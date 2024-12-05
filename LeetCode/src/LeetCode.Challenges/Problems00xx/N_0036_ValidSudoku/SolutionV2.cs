namespace LeetCode.Challenges.Problems00xx.N_0036_ValidSudoku;

public static class SolutionV2
{
    private const int BoardSize = 9;

    public static bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<char>[BoardSize];
        var columns = new HashSet<char>[BoardSize];
        var squares = new HashSet<char>[BoardSize];

        for (var i = 0; i < BoardSize; i++)
        {
            rows[i] = new HashSet<char>(BoardSize);
            columns[i] = new HashSet<char>(BoardSize);
            squares[i] = new HashSet<char>(BoardSize);
        }

        for (var i = 0; i < BoardSize; i++)
        {
            for (var j = 0; j < BoardSize; j++)
            {
                var current = board[i][j];
                if (current == '.')
                {
                    continue;
                }

                // See the file "Notes.md" for more info.
                var squareIndex = (i / 3) * 3 + (j / 3);

                if (rows[i].Contains(current) ||
                    columns[j].Contains(current) ||
                    squares[squareIndex].Contains(current))
                {
                    return false;
                }

                rows[i].Add(current);
                columns[j].Add(current);
                squares[squareIndex].Add(current);
            }
        }

        return true;
    }
}
