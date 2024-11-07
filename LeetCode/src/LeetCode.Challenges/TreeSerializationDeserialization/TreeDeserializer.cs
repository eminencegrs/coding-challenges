namespace LeetCode.Challenges.TreeSerializationDeserialization;

public class TreeDeserializer
{
    private string[] nodes = [];
    private int index;

    public TreeNode? Deserialize(string tree)
    {
        ArgumentNullException.ThrowIfNull(tree);
        this.nodes = tree.Split(";");

        if (this.nodes.Length == 0)
        {
            return null;
        }

        this.index = 0;
        return this.Dfs();
    }

    private TreeNode? Dfs()
    {
        if (this.nodes[this.index].Equals("@", StringComparison.Ordinal))
        {
            this.index++;
            return null;
        }

        var node = new TreeNode
        {
            Value = int.Parse(this.nodes[this.index])
        };

        this.index++;

        node.Left = this.Dfs();
        node.Right = this.Dfs();

        return node;
    }
}
