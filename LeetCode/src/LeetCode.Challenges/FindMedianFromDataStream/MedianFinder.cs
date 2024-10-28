namespace LeetCode.Challenges.FindMedianFromDataStream;

public class MedianFinder
{
    private readonly PriorityQueue<int, int> left = new();
    private readonly PriorityQueue<int, int> right = new();

    public void AddNumber(int num)
    {
        this.left.Enqueue(num, -num);

        if (this.left.TryDequeue(out int maxFromLeft, out int _))
        {
            this.right.Enqueue(maxFromLeft, maxFromLeft);
        }

        if (this.right.Count > this.left.Count)
        {
            if (this.right.TryDequeue(out int minFromRight, out int _))
            {
                this.left.Enqueue(minFromRight, -minFromRight);
            }
        }
    }

    public double GetMedian()
    {
        if (this.left.Count == this.right.Count)
        {
            if (this.left.TryPeek(out int maxLeft, out int _) && this.right.TryPeek(out int minRight, out int _))
            {
                return (maxLeft + minRight) / 2.0;
            }
        }
        else
        {
            if (this.left.TryPeek(out int maxLeft, out int _))
            {
                return maxLeft;
            }
        }

        throw new InvalidOperationException("Could not determine median due to an invalid heap state.");
    }
}
