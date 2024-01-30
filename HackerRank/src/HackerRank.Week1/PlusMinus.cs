namespace HackerRank.Week1;

public class PlusMinus
{
    public void Process(List<int> arr)
    {
        decimal negative = arr.Count(x => x < 0);
        decimal positive = arr.Count(x => x > 0);
        decimal zeroes = arr.Count(x => x == 0);
        Console.WriteLine($"{positive / arr.Count:0.000000}");
        Console.WriteLine($"{negative / arr.Count:0.000000}");
        Console.WriteLine($"{zeroes / arr.Count:0.000000}");
    }
}
