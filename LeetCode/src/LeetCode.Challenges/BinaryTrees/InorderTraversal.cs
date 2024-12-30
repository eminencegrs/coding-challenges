namespace LeetCode.Challenges.BinaryTrees;

public class InorderTraversal
{
    public static string SerializeInorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
    {
        if (node == null)
        {
            return nullMark;
        }

        var leftSerialized = SerializeInorder(node.Left, delimiter, nullMark);
        var rightSerialized = SerializeInorder(node.Right, delimiter, nullMark);

        return $"{leftSerialized}{delimiter}{node.Value}{delimiter}{rightSerialized}";
    }
}
