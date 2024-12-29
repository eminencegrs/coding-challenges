namespace DailyCodingProblem.Challenges.Y2024.M12.Day29;

// Time Complexity: O(n).
// Space Complexity: O(n).
public static class HashSetSolution
{
    public static int FindDuplicate(int[] numbers)
    {
        var duplicates = new HashSet<int>();
        foreach (var number in numbers)
        {
            if (!duplicates.Add(number))
            {
                return number;
            }
        }

        throw new InvalidOperationException();
    }
}
