namespace DailyCodingProblem.Challenges.Y2025.M01.Day31;

public class Solution
{
    public static int FindTheMostFrequentSubtreeSum(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var frequenciesPerNodeValues = new Dictionary<int, int>();
        var maxFrequency = 0;

        ComputeSubtreeSum(root);

        foreach (var pair in frequenciesPerNodeValues)
        {
            if (pair.Value == maxFrequency)
            {
                return pair.Key;
            }
        }

        throw new InvalidOperationException();

        int ComputeSubtreeSum(TreeNode? node)
        {
            if (node == null)
            {
                return 0;
            }

            var leftSum = ComputeSubtreeSum(node.Left);
            var rightSum = ComputeSubtreeSum(node.Right);
            var sum = node.Value + leftSum + rightSum;

            frequenciesPerNodeValues.TryAdd(sum, 0);
            frequenciesPerNodeValues[sum]++;

            maxFrequency = Math.Max(maxFrequency, frequenciesPerNodeValues[sum]);

            return sum;
        }
    }
}
