namespace LeetCode.Challenges.BinaryTrees;

public class LevelOrderTraversal
{
    public static string SerializeLevelOrder(TreeNode? node, string delimiter = ";", string nullMark = "#")
    {
        if (node == null)
        {
            return nullMark;
        }

        var result = new List<string>();
        var queue = new Queue<TreeNode?>();

        // Add the current root.
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            // Visit the next node.
            var currentNode = queue.Dequeue();
            if (currentNode == null)
            {
                result.Add(nullMark);
            }
            else
            {
                // Serialize it.
                result.Add(currentNode.Value);

                // Enqueue its left and right children to process the next level in a proper order.
                queue.Enqueue(currentNode.Left);
                queue.Enqueue(currentNode.Right);
            }
        }

        return string.Join(delimiter, result);
    }
}
