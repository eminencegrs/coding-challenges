namespace DailyCodingProblem.Challenges.Y2024.M08;

public static class Day04Task
{
    public static class BruteForceApproach
    {
        public static int[] GetResult(int[] numbers, int k)
        {
            var result = new List<int>();
            for (var i = 0; i <= numbers.Length - k; i++)
            {
                var max = int.MinValue;
                for (var j = i; j < i + k; j++)
                {
                    if (numbers[j] >= max)
                    {
                        max = numbers[j];
                    }
                }

                result.Add(max);
            }

            return result.ToArray();
        }
    }

    // TODO: Refactoring is required.
    public static class SlidingWindowApproach
    {
        public static int[] GetResult(int[] numbers, int k)
        {
            var result = new List<int>();
            var indices = new LinkedList<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                // Remove indices of elements not in the current window.
                // It checks whether the front element in the `indices` (the oldest element in the window)
                // is out of the current window's range (i - k + 1). If so, it removes that index from the indices.
                if (indices.First != null && indices.Count > 0 && indices.First.Value < i - k + 1)
                {
                    indices.RemoveFirst();
                }

                // Remove elements from the deque that are smaller than the current element
                // since they are not useful anymore.
                while (indices.Last != null && indices.Count > 0 && numbers[indices.Last.Value] <= numbers[i])
                {
                    indices.RemoveLast();
                }

                // Add the current element's index to the deque.
                indices.AddLast(i);

                // The first element in the deque is the largest in the current window.
                if (i >= k - 1)
                {
                    result.Add(numbers[indices.First.Value]);
                }
            }

            return result.ToArray();
        }
    }
}
