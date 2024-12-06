namespace LeetCode.Challenges.Problems00xx.N_0079_WordSearch;

public static class Solution
{
    public static bool Exist(char[][] board, string word)
    {
        var rows = board.Length;
        var cols = board[0].Length;
        var visited = new bool[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (Dfs(row, col, 0))
                {
                    return true;
                }
            }
        }

        return false;

        bool Dfs(int i, int j, int index)
        {
            if (i < 0 || i >= rows || j < 0 || j >= cols || visited[i, j] || board[i][j] != word[index])
            {
                return false;
            }

            if (index == word.Length - 1)
            {
                return true;
            }

            visited[i, j] = true;

            bool found =
                Dfs(i + 1, j, index + 1) ||
                Dfs(i - 1, j, index + 1) ||
                Dfs(i, j + 1, index + 1) ||
                Dfs(i, j - 1, index + 1);

            visited[i, j] = false;

            return found;
        }
    }
}
