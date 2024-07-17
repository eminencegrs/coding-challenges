namespace LeetCode.Challenges.TwoSum;

public static class TwoPointerWithSortingSolution
{
    public static int[] GetResult(int[] numbers, int target)
    {
        List<(int number, int originalIndex)> sortedNumbersWithIndex = numbers.Select((n, i) => (n, i)).ToList();
        sortedNumbersWithIndex.Sort((a, b) => a.number.CompareTo(b.number));

        int leftPointer = 0;
        int rightPointer = sortedNumbersWithIndex.Count - 1;

        while (leftPointer < rightPointer)
        {
            int sum = sortedNumbersWithIndex[leftPointer].number + sortedNumbersWithIndex[rightPointer].number;
            if (sum == target)
            {
                return [sortedNumbersWithIndex[leftPointer].originalIndex, sortedNumbersWithIndex[rightPointer].originalIndex];
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

        throw new InvalidOperationException("Solution Not Found");
    }
}
