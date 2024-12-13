namespace LeetCode.Challenges.CoinChangeII;

public static class RecursionWithMemo
{
    public static int Change(int amount, int[] coins)
    {
        var cache = new Dictionary<(int, int), int>();

        // Start recursion with the full amount and the first coin.
        return CountCombinations(0, amount);

        // A function for recursion with memoization.
        int CountCombinations(int index, int remaining)
        {
            // Base case: if remaining amount is 0, a valid combination is found.
            if (remaining == 0)
            {
                return 1;
            }

            // Base case: if index is out of bounds or remaining is negative, no combinations are possible.
            if (index >= coins.Length || remaining < 0)
            {
                return 0;
            }

            // Check if result is already cached.
            if (cache.TryGetValue((index, remaining), out int cachedResult))
            {
                return cachedResult;
            }

            // Recursive exploration:
            // 1. Include the current coin:
            // Stay at the same index, subtract its value from the remaining.
            int include = CountCombinations(index, remaining - coins[index]);

            // 2. Exclude the current coin: move to the next index.
            int exclude = CountCombinations(index + 1, remaining);

            // Store the result in the dictionary and return it
            cache[(index, remaining)] = include + exclude;
            return cache[(index, remaining)];
        }
    }
}
