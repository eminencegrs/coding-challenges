namespace LeetCode.Challenges.CoinChange;

// This is an optimized solution based on a bottom-up dynamic programming approach instead of recursion.
// This approach iterates through each possible amount from 1 to the target amount,
// calculating the minimum number of coins needed to make up each amount.
public class SolutionV2
{
    public int CoinChange(int[] coins, int amount)
    {
        // Initialize an array to store the minimum number of coins needed for each amount.
        var amountMins = new int[amount + 1];

        // Fill the array with an initial value greater than the target amount.
        Array.Fill(amountMins, amount + 1);

        // Base case: 0 coins needed to make up 0 amount.
        amountMins[0] = 0;

        // Iterate through each possible amount from 1 to the target amount.
        for (var tempAmount = 1; tempAmount <= amount; tempAmount++)
        {
            // Iterate through each coin denomination.
            foreach (var coin in coins)
            {
                // Check if the current coin denomination can be used to make up the current amount.
                if (tempAmount - coin >= 0)
                {
                    // Update the minimum number of coins needed for the current amount.
                    amountMins[tempAmount] = Math.Min(amountMins[tempAmount], amountMins[tempAmount - coin] + 1);
                }
            }
        }

        // If the target amount cannot be made up, return -1.
        return amountMins[amount] > amount ? -1 : amountMins[amount];
    }
}
