namespace DailyCodingProblem.Challenges.Y2024.M11.Day12;

// Time Complexity: O(n), where 'n' is the number of nodes.
// Space Complexity: O(w), where 'w' is the maximum width of the tree.
// It is typically proportional to the number of nodes in the largest level.
public static class Solution
{
    public static int GetTreeLevelWithMinSum(TreeNode? root)
    {
        if (root == null) return -1;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var resultDepth = -1;
        var minSum = int.MaxValue;
        var depth = 0;

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            var currentSum = 0;

            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                currentSum += node.Value;

                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                resultDepth = depth;
            }

            depth++;
        }

        return resultDepth;
    }
}
