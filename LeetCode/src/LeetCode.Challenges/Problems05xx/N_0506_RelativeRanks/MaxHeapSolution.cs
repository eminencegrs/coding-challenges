namespace LeetCode.Challenges.Problems05xx.N_0506_RelativeRanks;

public static class MaxHeapSolution
{
    public static string[] FindRelativeRanks(int[] scores)
    {
        var priorityQueue = new PriorityQueue<(int Score, int Index), int>();
        for (var i = 0; i < scores.Length; i++)
        {
            // The negative score is used for max-heap behavior.
            priorityQueue.Enqueue((scores[i], i), -scores[i]);
        }

        var result = new string[scores.Length];
        var rank = 1;
        while (priorityQueue.Count > 0)
        {
            var (_, index) = priorityQueue.Dequeue();
            result[index] = rank switch
            {
                1 => "Gold Medal",
                2 => "Silver Medal",
                3 => "Bronze Medal",
                _ => rank.ToString()
            };

            rank++;
        }

        return result;
    }
}
