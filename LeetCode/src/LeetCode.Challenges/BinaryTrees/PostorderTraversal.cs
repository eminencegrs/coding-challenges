namespace LeetCode.Challenges.BinaryTrees;

public class PostorderTraversal
{
    public string SerializePostorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
    {
        if (node == null)
        {
            return nullMark;
        }

        var leftSerialized = this.SerializePostorder(node.Left, delimiter, nullMark);
        var rightSerialized = this.SerializePostorder(node.Right, delimiter, nullMark);

        return $"{leftSerialized}{delimiter}{rightSerialized}{delimiter}{node.Value}";
    }
}
