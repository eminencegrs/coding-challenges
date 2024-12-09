namespace LeetCode.Challenges.Problems02xx.N_0257_BinaryTreePaths;

public static class Solution
{
    public static IList<string> BinaryTreePaths(TreeNode? root)
    {
        var paths = new List<string>();
        Traverse(root, []);
        return paths;

        void Traverse(TreeNode? node, IList<int> current)
        {
            if (node == null)
            {
                // Do nothing, as we do not know if the current node is a leaf.
                return;
            }

            // Add the current node to the path.
            current.Add(node.Value);

            if (node.Left == null && node.Right == null)
            {
                // The path has been found and can be added to the final result.
                paths.Add(string.Join("->", current));
            }
            else
            {
                Traverse(node.Left, current);
                Traverse(node.Right, current);
            }

            // Backtrack to remove the current node from the path.
            current.RemoveAt(current.Count - 1);
        }
    }
}
