namespace HackerRank.Week1;

public class LonelyInteger
{
    public int FindUniqueNumberV1(List<int> numbers)
    {
        var items = new Dictionary<int, int>();
        foreach (var number in numbers)
        {
            if (items.TryGetValue(number, out _))
            {
                items[number]++;
            }
            else
            {
                items.TryAdd(number, 1);
            }
        }

        return items.FirstOrDefault(x => x.Value == 1).Key;
    }

    public int FindUniqueNumberV2(List<int> numbers)
    {
        int result = 0;

        foreach (int number in numbers)
        {
            result ^= number;
        }

        return result;
    }
    
    public int FindUniqueNumberV3(List<int> numbers)
    {
        return numbers.Aggregate(0, (current, number) => current ^ number);
    }
}
