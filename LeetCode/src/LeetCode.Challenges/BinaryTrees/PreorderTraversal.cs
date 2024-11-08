namespace LeetCode.Challenges.BinaryTrees;

public class PreorderTraversal
{
    public string SerializePreorder(TreeNode? node, string delimiter = ";", string nullMark = "#")
    {
        if (node == null)
        {
            return nullMark;
        }

        var leftSerialized = this.SerializePreorder(node.Left, delimiter, nullMark);
        var rightSerialized = this.SerializePreorder(node.Right, delimiter, nullMark);

        return $"{node.Value}{delimiter}{leftSerialized}{delimiter}{rightSerialized}";
    }
}
