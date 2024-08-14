namespace DailyCodingProblem.Challenges.Y2024.M07;

// This problem was asked by Uber.
// Given an array of integers, return a new array such that each element at index `i` of the new array
// is the product of all the numbers in the original array except the one at `i`.
// 
// For example, if our input was `[1, 2, 3, 4, 5]`, the expected output would be `[120, 60, 40, 30, 24]`.
// If our input was `[3, 2, 1]`, the expected output would be `[2, 3, 6]`.
// 
// Follow-up: what if you can't use division?
public static class Day19
{
    public static int[] GetResult(int[] numbers)
    {
        var result = new int[numbers.Length];
        if (numbers.Length == 0)
        {
            return Enumerable.Empty<int>().ToArray();
        }

        if (numbers.Any(x => x == 0))
        {
            return numbers.Select(_ => 0).ToArray();
        }

        var totalProduct = 1;
        for (var i = 0; i < numbers.Length; i++)
        {
            totalProduct *= numbers[i];
        }

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = totalProduct / numbers[i];
        }

        return result;
    }

    public static int[] GetResultNotUsingDivision(int[] numbers)
    {
        var result = new int[numbers.Length];
        if (numbers.Length == 0)
        {
            return [];
        }

        if (numbers.Any(x => x == 0))
        {
            return numbers.Select(_ => 0).ToArray();
        }

        var leftProduct = new int[numbers.Length];
        for (var i = 0; i < numbers.Length; i++)
        {
            leftProduct[i] = i == 0 ? 1 : leftProduct[i - 1] * numbers[i - 1];
        }

        var rightProduct = new int[numbers.Length];
        for (var i = numbers.Length - 1; i >= 0; i--)
        {
            rightProduct[i] = i == numbers.Length - 1 ? 1 : rightProduct[i + 1] * numbers[i + 1];
        }

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = leftProduct[i] * rightProduct[i];
        }

        return result;
    }
}
