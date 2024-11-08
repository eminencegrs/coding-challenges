namespace LeetCode.Challenges.BinaryTrees;

public class InorderTraversal
{
    public string SerializeInorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
    {
        if (node == null)
        {
            return nullMark;
        }

        var leftSerialized = this.SerializeInorder(node.Left, delimiter, nullMark);
        var rightSerialized = this.SerializeInorder(node.Right, delimiter, nullMark);

        return $"{leftSerialized}{delimiter}{node.Value}{delimiter}{rightSerialized}";
    }
}
