namespace LeetCode.Challenges.TwoSum2;

// Time Complexity: O(n).
public static class TwoPointerSolution
{
    public static int[] GetResult(int[] numbers, int target)
    {
        int leftPointer = 0;
        int rightPointer = numbers.Length - 1;

        while (leftPointer < rightPointer)
        {
            int sum = numbers[leftPointer] + numbers[rightPointer];
            if (sum == target)
            {
                return [leftPointer + 1, rightPointer + 1];
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
