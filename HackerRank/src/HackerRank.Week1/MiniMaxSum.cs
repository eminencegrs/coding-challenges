namespace HackerRank.Week1;

public class MiniMaxSum
{
    public void Process(List<int> numbers)
    {
        var max = long.MinValue;
        var min = long.MaxValue;
        long totalSum = 0;

        foreach (var number in numbers)
        {
            totalSum += number;

            max = number > max ? number : max;
            min = number < min ? number : min;
        }

        var maxSum = totalSum - min;
        var minSum = totalSum - max;

        Console.WriteLine($"{minSum} {maxSum}");
    }
}
