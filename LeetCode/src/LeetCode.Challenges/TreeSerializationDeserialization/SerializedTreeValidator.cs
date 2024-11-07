namespace LeetCode.Challenges.TreeSerializationDeserialization;

public class SerializedTreeValidator
{
    public bool ValidateIfPreOrderTraversal(string tree)
    {
        ArgumentNullException.ThrowIfNull(tree);
        var items = tree.Split(";");
        var stack = new Stack<string>();

        foreach (var item in items)
        {
            stack.Push(item);

            // Reduce the stack while we have at least three items:
            // the top 2 are "@" symbols (null nodes), indicating the completion of a subtree,
            // and the 3rd item from the top is a non-null node (the parent of this subtree).
            while (
                stack.Count >= 3 &&
                stack.Peek().Equals("@", StringComparison.Ordinal) &&
                stack.Skip(1).First().Equals("@", StringComparison.Ordinal) &&
                !stack.Skip(2).First().Equals("@", StringComparison.Ordinal))
            {
                // Remove the two "@" (null nodes).
                stack.Pop();
                stack.Pop();

                // Replace the parent node with "@" to mark this subtree as completed and valid.
                // By doing this, we simplify the stack, effectively removing this subtree from further checks.
                stack.Pop();
                stack.Push("@");
            }
        }

        // A valid serialization should reduce the stack to exactly one "@" at the end,
        // indicating that all subtrees are complete and valid, with only the root node remaining.
        return stack.Count == 1 && stack.Peek() == "@";
    }
}
