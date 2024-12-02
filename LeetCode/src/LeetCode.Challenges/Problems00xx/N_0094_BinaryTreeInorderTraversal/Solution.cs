namespace LeetCode.Challenges.Problems00xx.N_0094_BinaryTreeInorderTraversal;

public class Solution
{
    public IList<int> InorderTraversal(TreeNode? root)
    {
        if (root == null)
        {
            return Enumerable.Empty<int>().ToList();
        }

        var result = new List<int>();
        this.Traverse(root, result);
        return result;
    }

    private void Traverse(TreeNode? node, IList<int> result)
    {
        if (node == null)
        {
            return;
        }

        this.Traverse(node.Left, result);

        result.Add(node.Value);

        this.Traverse(node.Right, result);
    }
}
