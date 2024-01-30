namespace HackerRank.Week1;

public class MatrixFlipping
{
    public int GetUpperLeftQuadrantMaxSum(List<List<int>> matrix)
    {
        int size = matrix.Count;
        int sum = 0;
        for (int i = 0; i < size / 2; i++)
        {
            for (int j = 0; j < size / 2; j++)
            {
                int upperLeft = matrix[i][j];
                int upperRight = matrix[i][size - j - 1];
                int bottomLeft = matrix[size - i - 1][j];
                int bottomRight = matrix[size - i - 1][size - j - 1];
                sum += Math.Max(Math.Max(Math.Max(upperLeft, upperRight), bottomLeft), bottomRight);
            }
        }

        return sum;
    }
}
