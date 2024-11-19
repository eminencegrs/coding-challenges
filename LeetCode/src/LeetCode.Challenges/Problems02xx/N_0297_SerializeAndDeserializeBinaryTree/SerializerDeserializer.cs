using System.Text;

namespace LeetCode.Challenges.Problems02xx.N_0297_SerializeAndDeserializeBinaryTree;

// This solution implements serialization and deserialization of a binary tree using level-order traversal.
// Key Points:
//  1. Level-Order Traversal: Both serialization and deserialization follow a level-order traversal,
//     ensuring that the binary tree structure is preserved.
//  2. Null Nodes: null child nodes are represented by empty entries between semicolons (";").
//     In the serialized string, empty spaces between values indicate missing left or right children.
//  3. Queue for Rebuilding the Tree: A queue is used during deserialization to ensure
//     that nodes are processed in the correct order.
public class SerializerDeserializer
{
    public string? Serialize(TreeNode? root)
    {
        if (root == null)
        {
            return string.Empty;
        }

        var sb = new StringBuilder();

        // The queue is used to implement the level-order traversal.
        // It starts by enqueuing the root of the tree into the queue.
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);

        // The loop continues as long as there are nodes in the queue to process.
        // For each node in the queue:
        //  -- If the node is null, it appends a semicolon (;) to represent the absence of a child node.
        //     This indicates a missing left or right child in the tree.
        //  -- If the node is not null, it appends its value to the StringBuilder, followed by a semicolon (;),
        //     and enqueue its left and right children for further processing.
        //     Even if the children are null, they are enqueued,
        //     and the null entries are handled in the next iterations.
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node == null)
            {
                sb.Append(';');
            }
            else
            {
                sb.Append(node.Value);
                sb.Append(';');
                queue.Enqueue(node.Left);
                queue.Enqueue(node.Right);
            }
        }

        // Trim the trailing semicolon.
        return sb.ToString().TrimEnd(';');
    }

    public TreeNode? Deserialize(string? data)
    {
        if (string.IsNullOrWhiteSpace(data))
        {
            return null;
        }

        var nodes = data.Split(";");
        if (nodes.Length == 0)
        {
            return null;
        }

        var root = new TreeNode(int.Parse(nodes[0]));

        // A queue is used to track the nodes in the tree while it reconstructs the tree.
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // The 'index' variable is used to iterate through the serialized data
        // starting from the 2nd element, as the 1st one is used for the root.
        var index = 1;

        while (queue.Count > 0 && index < nodes.Length)
        {
            var currentNode = queue.Dequeue();

            if (index < nodes.Length && !string.IsNullOrEmpty(nodes[index]))
            {
                currentNode.Left = new TreeNode(int.Parse(nodes[index]));
                queue.Enqueue(currentNode.Left);
            }

            index++;

            if (index < nodes.Length && !string.IsNullOrEmpty(nodes[index]))
            {
                currentNode.Right = new TreeNode(int.Parse(nodes[index]));
                queue.Enqueue(currentNode.Right);
            }

            index++;
        }

        return root;
    }
}