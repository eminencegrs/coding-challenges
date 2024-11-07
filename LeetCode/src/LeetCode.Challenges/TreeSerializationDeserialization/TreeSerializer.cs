using System.Text;

namespace LeetCode.Challenges.TreeSerializationDeserialization;

public class TreeSerializer
{
    public string Serialize(TreeNode? root)
    {
        if (root == null)
        {
            return "@";
        }

        var sb = new StringBuilder();
        sb.Append(root.Value);
        sb.Append(';');
        sb.Append(this.Serialize(root.Left));
        sb.Append(';');
        sb.Append(this.Serialize(root.Right));
        return sb.ToString();
    }
}
