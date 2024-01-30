namespace HackerRank.Week1;

public class Median
{
    public int Get(List<int> items)
    {
        items.Sort();
        int middleIndex = items.Count / 2;
        int median = items.Count % 2 == 0
            ? (items[middleIndex - 1] + items[middleIndex]) / 2
            : items[middleIndex];

        return median;
    }
}
