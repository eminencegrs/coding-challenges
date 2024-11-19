namespace LeetCode.Challenges.Problems01xx.N_0135_Candy;

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
        var candies = Enumerable.Repeat(1, ratings.Length).ToArray();

        for (var i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1] && candies[i] <= candies[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

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
