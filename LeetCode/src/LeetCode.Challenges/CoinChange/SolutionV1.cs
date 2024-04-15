﻿namespace LeetCode.Challenges.CoinChange;

public class SolutionV1
{
    public int CoinChange(int[] coins, int amount)
    {
        var cache = new Dictionary<int, int>();

        int GetChange(int tempAmount)
        {
            if (tempAmount == 0)
            {
                return 0;
            }

            if (tempAmount < 0)
            {
                return -1;
            }

            if (cache.TryGetValue(tempAmount, out var change))
            {
                return change;
            }

            var minCoins = int.MaxValue;
            foreach (var coin in coins)
            {
                var res = GetChange(tempAmount - coin);
                if (res >= 0)
                {
                    minCoins = Math.Min(minCoins, res + 1);
                }
            }

            cache[tempAmount] = minCoins != int.MaxValue ? minCoins : -1;
            return cache[tempAmount];
        }

        return GetChange(amount);
    }
}
