namespace DailyCodingProblem.Challenges.Y2024.M07;

// This problem was asked by Google.
// Given a list of numbers and a number `k`, return whether any two numbers from the list add up to `k`.
// For example, given `[10, 15, 3, 7]` and `k` of `17`, return true since `10 + 7` is `17`.
// Bonus: Can you do this in one pass?
public static class Day18Task
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
            var current = numbers[leftPointer] + numbers[rightPointer];
            if (current == target)
            {
                return true;
            }

            if (current < target)
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
