namespace LeetCode.Challenges.Problems03xx.N_0331_VerifyPreorderSerializationOfBinaryTree;

public static class Validator
{
    public static bool IsValidSerialization(string preorder)
    {
        ArgumentNullException.ThrowIfNull(preorder);

        var items = preorder.Split(",");
        var stack = new Stack<string>();

        foreach (var item in items)
        {
            stack.Push(item);

            while (
                stack.Count >= 3 &&
                stack.Peek().Equals("#", StringComparison.Ordinal) &&
                stack.Skip(1).First().Equals("#", StringComparison.Ordinal) &&
                !stack.Skip(2).First().Equals("#", StringComparison.Ordinal))
            {
                // Remove the 1st child.
                stack.Pop();
                // Remove the 2nd child.
                stack.Pop();
                // Remove their parent node.
                stack.Pop();
                // Replace the whole subtree with the '#' symbol.
                stack.Push("#");
            }
        }

        return stack.Count == 1 && stack.Peek() == "#";
    }
}
