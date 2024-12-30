namespace LeetCode.Challenges.BinaryTrees;

public class PostorderTraversal
{
    public static string SerializePostorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
    {
        if (node == null)
        {
            return nullMark;
        }

        var leftSerialized = SerializePostorder(node.Left, delimiter, nullMark);
        var rightSerialized = SerializePostorder(node.Right, delimiter, nullMark);

        return $"{leftSerialized}{delimiter}{rightSerialized}{delimiter}{node.Value}";
    }
}
