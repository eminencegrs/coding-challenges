namespace HackerRank.Week1;

public class DiagonalDifference
{
    public int Calculate(List<List<int>> array)
    {
        var firstSum = 0;
        var secondSum = 0;
        
        for (var i = 0; i < array.Count; i++)
        {
            firstSum += array[i][i];
        }

        for (var i = 0; i < array.Count; i++)
        {
            secondSum += array[i][array.Count - 1 - i];
        }
        
        return Math.Abs(firstSum - secondSum);
    }
}
