namespace LeetCode.Challenges.MaxProductSubarray;

// Time Complexity: O(n).
public class TwoPassApproach
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

        var leftToRightPassMax = int.MinValue;
        var product = 1;
        foreach (var number in numbers)
        {
            product *= number;
            leftToRightPassMax = Math.Max(leftToRightPassMax, product);

            if (number == 0)
            {
                product = 1;
            }
        }

        int rightToLeftPassMax = int.MinValue;
        product = 1;
        for (var i = numbers.Length - 1; i >= 0; i--)
        {
            product *= numbers[i];
            rightToLeftPassMax = Math.Max(rightToLeftPassMax, product);

            if (numbers[i] == 0)
            {
                product = 1;
            }
        }

        return Math.Max(leftToRightPassMax, rightToLeftPassMax);
    }
}
