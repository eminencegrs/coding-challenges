namespace DailyCodingProblem.Challenges.Y2025.M02.Day01;

public static class Solution
{
    public static void Rotate(int[] array, int k, string direction)
    {
        var length = array.Length;
        if (length == 0)
        {
            return;
        }

        // Handle cases where k > n.
        k = k % length;

        if (direction == "left")
        {
            // Left rotation is equivalent to right rotation by (n - k).
            k = length - k;
        }

        // Perform the three-step reversal.
        // Step 1: Reverse entire array.
        Reverse(array, 0, length - 1);

        // Step 2: Reverse first k elements.
        Reverse(array, 0, k - 1);

        // Step 3: Reverse remaining elements.
        Reverse(array, k, length - 1);
    }

    private static void Reverse(int[] array, int start, int end)
    {
        while (start < end)
        {
            (array[start], array[end]) = (array[end], array[start]);
            start++;
            end--;
        }
    }
}
