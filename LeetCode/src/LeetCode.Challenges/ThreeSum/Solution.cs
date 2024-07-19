namespace LeetCode.Challenges.ThreeSum;

public static class Solution
{
    public static IList<IList<int>> GetResult(int[] numbers)
    {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(numbers);
        var n = numbers.Length;
        for (var i = 0; i < n; i++)
        {
            if (i > 0 && numbers[i] == numbers[i - 1])
            {
                continue;
            }

            var left = i + 1;
            var right = n - 1;
            var target = -numbers[i];
            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    result.Add([numbers[i], numbers[left], numbers[right]]);

                    while (left < right && numbers[left] == numbers[left + 1])
                    {
                        left++;
                    }

                    while (left < right && numbers[right] == numbers[right - 1])
                    {
                        right--;
                    }

                    left++;
                    right--;

                    continue;
                }

                if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}
