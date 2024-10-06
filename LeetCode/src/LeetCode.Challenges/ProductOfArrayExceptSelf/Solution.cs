namespace LeetCode.Challenges.ProductOfArrayExceptSelf;

// Time Complexity: O(n).
public class Solution
{
    public int[] ProductExceptSelf(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return [];
        }

        var result = new int[numbers.Length];

        // Initialize the first element of the result array.
        // The product of elements to the left of the 1st element is 1 since no elements to the left.
        result[0] = 1;

        // First pass: Calculate the product of all elements to the left of each index.
        for (var i = 1; i < numbers.Length; i++)
        {
            // At each step, multiply the current number with the product of all previous numbers.
            result[i] = result[i - 1] * numbers[i - 1];
        }

        // Initialize a variable to keep track of the product of elements to the right of each index.
        // Initially, rightProduct is set to 1 because there are no elements to the right of the last element.
        var rightProduct = 1;

        // Traverse the array from right to left and update the result array.
        for (var i = numbers.Length - 1; i >= 0; i--)
        {
            // Multiply the left product by the right product to get the final product for each index.
            result[i] *= rightProduct;

            // Update the rightProduct by multiplying it with numbers[i] (the current element).
            rightProduct *= numbers[i];
        }

        return result;
    }
}
