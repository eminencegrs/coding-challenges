namespace LeetCode.Challenges.TwoSum;

public class Solution
{
    public int[] GetResult(int[] numbers, int target)
    {
        var result = new int[2];
        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] != target)
                {
                    continue;
                }

                result[0] = i;
                result[1] = j;
                return result;
            }
        }

        return Array.Empty<int>();
    }
}
