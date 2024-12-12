namespace LeetCode.Challenges.Problems25xx.N_2558_TakeGiftsFromTheRichestPile;

public static class BruteForceSolution
{
    public static long PickGifts(int[] gifts, int k)
    {
        var maxIndex = gifts.Length - 1;
        for (var i = 1; i <= k; i++)
        {
            Array.Sort(gifts);
            gifts[maxIndex] = (int)Math.Sqrt(gifts[maxIndex]);
        }

        return gifts.Select(x => (long)x).Sum();
    }
}
