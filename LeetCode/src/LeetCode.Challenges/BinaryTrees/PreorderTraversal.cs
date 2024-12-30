namespace LeetCode.Challenges.BinaryTrees;

public class PreorderTraversal
{
    public static string SerializePreorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
    {
        if (node == null)
        {
            return nullMark;
        }

        var leftSerialized = SerializePreorder(node.Left, delimiter, nullMark);
        var rightSerialized = SerializePreorder(node.Right, delimiter, nullMark);

        return $"{node.Value}{delimiter}{leftSerialized}{delimiter}{rightSerialized}";
    }
}
