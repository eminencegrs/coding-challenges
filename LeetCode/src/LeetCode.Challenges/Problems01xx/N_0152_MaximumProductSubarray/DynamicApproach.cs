namespace LeetCode.Challenges.Problems01xx.N_0152_MaximumProductSubarray;

// Time Complexity: O(n).
public class DynamicApproach
{
    public int MaxProduct(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            throw new ArgumentException($"The {nameof(numbers)} array must not be empty.");
        }

        if (numbers.Length == 1)
        {
            return numbers[0];
        }

        var maxProduct = numbers[0];
        var currentMax = numbers[0];
        var currentMin = numbers[0];

        for (var i = 1; i < numbers.Length; i++)
        {
            var current = numbers[i];

            // Swap currentMax and currentMin if numbers[i] is negative.
            if (current < 0)
            {
                currentMax ^= currentMin;
                currentMin ^= currentMax;
                currentMax ^= currentMin;
            }

            currentMax = Math.Max(current, currentMax * current);
            currentMin = Math.Min(current, currentMin * current);

            maxProduct = Math.Max(maxProduct, currentMax);
        }

        return maxProduct;
    }
}
