namespace DailyCodingProblem.Challenges.Year2024.Month07July;

// This problem was asked by Google.
// Given a list of numbers and a number `k`, return whether any two numbers from the list add up to `k`.
// For example, given `[10, 15, 3, 7]` and `k` of `17`, return true since `10 + 7` is `17`.
// Bonus: Can you do this in one pass?
public static class Day18
{
    public static bool GetResult(int[] numbers, int target)
    {
        if (numbers.Length == 0)
        {
            return false;
        }

        Array.Sort(numbers);

        var leftPointer = 0;
        var rightPointer = numbers.Length - 1;

        while (leftPointer < rightPointer)
        {
            if (numbers[leftPointer] + numbers[rightPointer] == target)
            {
                return true;
            }

            if (numbers[leftPointer] + numbers[rightPointer] < target)
            {
                leftPointer++;
            }
            else
            {
                rightPointer--;
            }
        }

        return false;
    }
}
