namespace LeetCode.Challenges.Problems01xx.N_0135_Candy;

// Time Complexity: O(n).
// Space Complexity: O(n).
public static class Solution
{
    public static int Candy(int[] ratings)
    {
        return ratings.Length switch
        {
            0 => 0,
            1 => 1,
            _ => GetCandies(ratings)
        };
    }

    private static int GetCandies(int[] ratings)
    {
        // Initialize the candies array with 1 candy for each child.
        // Each child must have at least one candy.
        var candies = Enumerable.Repeat(1, ratings.Length).ToArray();

        // Left-to-right pass:
        // Ensure that each child has more candies than their left neighbor if their rating is higher.
        for (var i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1] && candies[i] <= candies[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

        // Right-to-left pass:
        // Ensure that each child has more candies than their right neighbor if their rating is higher.
        // This ensures the final allocation is correct.
        for (var i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1] && candies[i] <= candies[i + 1])
            {
                candies[i] = candies[i + 1] + 1;
            }
        }

        return candies.Sum();
    }
}
