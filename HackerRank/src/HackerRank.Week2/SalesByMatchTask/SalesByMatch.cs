namespace HackerRank.Week2.SalesByMatchTask;

public class SalesByMatch
{
    public int GetSockPairs(int n, List<int> mess)
    {
        var socksByColors = new Dictionary<int, int>();
        foreach (var sock in mess)
        {
            if (socksByColors.TryGetValue(sock, out _))
            {
                socksByColors[sock] += 1;
            }
            else
            {
                socksByColors.Add(sock, 1);
            }
        }

        return socksByColors.Sum(i => i.Value / 2);
    }
}
