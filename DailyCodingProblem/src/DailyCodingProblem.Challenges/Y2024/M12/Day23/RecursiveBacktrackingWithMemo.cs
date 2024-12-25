namespace DailyCodingProblem.Challenges.Y2024.M12.Day23;

public static class RecursiveBacktrackingWithMemo
{
    public static int GetPaths(int[][] matrix)
    {
        var memo = new Dictionary<(int, int), int>();
        return Backtrack(0, 0, matrix.Length, matrix[0].Length);

        int Backtrack(int row, int col, int rows, int cols)
        {
            if (row >= rows || col >= cols || matrix[row][col] == 1)
            {
                return 0;
            }

            if (row == rows - 1 && col == cols - 1)
            {
                return 1;
            }

            if (memo.ContainsKey((row, col)))
            {
                return memo[(row, col)];
            }

            var rightPaths = Backtrack(row, col + 1, rows, cols);
            var downPaths = Backtrack(row + 1, col, rows, cols);

            memo[(row, col)] = rightPaths + downPaths;

            return memo[(row, col)];
        }
    }
}
