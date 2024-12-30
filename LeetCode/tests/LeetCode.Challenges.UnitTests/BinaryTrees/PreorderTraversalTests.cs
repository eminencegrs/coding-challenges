using LeetCode.Challenges.BinaryTrees;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.BinaryTrees;

public class PreorderTraversalTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTreeNode_WhenSerializePreorder_ThenResultAsExpected(TreeNode node, string expectedResult)
    {
        var actualResult = PreorderTraversal.SerializePreorder(node);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // The test tree:
        //        1
        //       / \
        //      2   3
        //     / \   \
        //    4   5   6
        //       / \
        //      7   8
        //
        // The serialized tree: "1;2;4;#;#;5;7;#;#;8;#;#;3;#;6;#;#".

        var root = new TreeNode
        {
            Value = "1",
            Left = new TreeNode
            {
                Value = "2",
                Left = new TreeNode { Value = "4" },
                Right = new TreeNode
                {
                    Value = "5",
                    Left = new TreeNode { Value = "7" },
                    Right = new TreeNode { Value = "8" }
                }
            },
            Right = new TreeNode
            {
                Value = "3",
                Right = new TreeNode { Value = "6" }
            }
        };

        yield return [root, "1;2;4;#;#;5;7;#;#;8;#;#;3;#;6;#;#"];
    }
}
