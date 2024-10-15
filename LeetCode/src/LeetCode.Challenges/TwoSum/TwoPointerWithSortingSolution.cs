namespace LeetCode.Challenges.TwoSum;

// Time Complexity: O(nlog(n)).
public static class TwoPointerWithSortingSolution
{
    public static int[] GetResult(int[] numbers, int target)
    {
        List<(int value, int index)> sortedNumbers = numbers.Select((n, i) => (n, i)).ToList();
        sortedNumbers.Sort((a, b) => a.value.CompareTo(b.value));

        int leftPointer = 0;
        int rightPointer = sortedNumbers.Count - 1;

        while (leftPointer < rightPointer)
        {
            int sum = sortedNumbers[leftPointer].value + sortedNumbers[rightPointer].value;
            if (sum == target)
            {
                return [sortedNumbers[leftPointer].index, sortedNumbers[rightPointer].index];
            }

            if (sum < target)
            {
                leftPointer++;
            }
            else
            {
                rightPointer--;
            }
        }

        throw new InvalidOperationException("Solution not found");
    }
}
