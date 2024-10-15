namespace LeetCode.Challenges.TwoSum2;

// Time Complexity: O(n).
public static class TwoPointerSolution
{
    public static int[] GetResult(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return [left + 1, right + 1];
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

        throw new InvalidOperationException(
            "The solution was not found because the test data violates the requirements. There must be exactly one solution.");
    }
}
