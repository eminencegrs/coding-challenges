namespace LeetCode.Challenges.Problems25xx.N_2558_TakeGiftsFromTheRichestPile;

// Time Complexity: O(log n)
public static class MaxHeapSolution
{
    public static long PickGifts(int[] gifts, int k)
    {
        PriorityQueue<int, int> maxHeap = new();
        foreach (var gift in gifts)
        {
            maxHeap.Enqueue(gift, -gift);
        }

        for (var i = 0; i < k; i++)
        {
            var maxGift = maxHeap.Dequeue();
            var remaining = (int)Math.Sqrt(maxGift);
            maxHeap.Enqueue(remaining, -remaining);
        }

        var totalRemaining = 0L;
        while (maxHeap.Count > 0)
        {
            totalRemaining += maxHeap.Dequeue();
        }

        return totalRemaining;
    }
}
