namespace LeetCode.Challenges.Problems05xx.N_0518_CoinChangeII;

public static class BacktrackingSolution
{
    public static int CoinChange(int amount, int[] coins)
    {
        var count = 0;
        Backtrack(0, amount);
        return count;

        void Backtrack(int start, int remaining)
        {
            // The base case: if the remaining amount is 0, we have found a valid combination.
            if (remaining == 0)
            {
                count++;
                return;
            }

            // If the remaining amount is negative, this path is invalid.
            if (remaining < 0)
            {
                return;
            }

            // Iterate through the coins, starting from the current index.
            for (var i = start; i < coins.Length; i++)
            {
                // Include the current coin and recurse.
                // 'i' ensures we can reuse the current coin.
                Backtrack(i, remaining - coins[i]); 
            }
        }
    }
}
