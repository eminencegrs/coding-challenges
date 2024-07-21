namespace LeetCode.Challenges.FourSum;

public static class Solution
{
    public static IList<IList<long>> GetResult(long[] numbers, long target)
    {
        IList<IList<long>> result = new List<IList<long>>();
        Array.Sort(numbers);
        var length = numbers.Length;

        // It relies on `length - 3` because we have 3 variables inside the main loop: `j`, `left` and `right`.
        // Adjusting the boundaries respectively.
        for (var i = 0; i < length - 3; i++)
        {
            // Skipping duplicates as only unique quadruplets must be considered.
            if (i > 0 && numbers[i] == numbers[i - 1])
            {
                continue;
            }

            // It relies on `length - 2` because we have 2 variables inside the second loop: `left` and `right`.
            // Adjusting the boundaries respectively.
            for (var j = i + 1; j < length - 2; j++)
            {
                // Skipping duplicates as only unique quadruplets must be considered.
                if (j > i + 1 && numbers[j] == numbers[j - 1])
                {
                    continue;
                }

                var left = j + 1;
                var right = length - 1;

                while (left < right)
                {
                    long sum = (long)numbers[i] + (long)numbers[j] + (long)numbers[left] + (long)numbers[right];
                    if (sum == target)
                    {
                        result.Add([numbers[i], numbers[j], numbers[left], numbers[right]]);

                        // Checking the nearest neighbours to avoid duplicates.
                        while (left < right && numbers[left] == numbers[left - 1])
                        {
                            left++;
                        }

                        // Checking the nearest neighbours to avoid duplicates.
                        while (left < right && numbers[right] == numbers[right - 1])
                        {
                            right--;
                        }
                    }

                    if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
