namespace LeetCode.Challenges.TwoSum;

public static class BruteForceSolution
{
    public static int[] GetResult(int[] numbers, int target)
    {
        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] != target)
                {
                    continue;
                }

                return [i, j];
            }
        }

        return Array.Empty<int>();
    }
}
