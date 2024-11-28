using LeetCode.Challenges.Problems01xx.N_0104_MaximumDepthOfBinaryTree;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems01xx.N_0104_MaximumDepthOfBinaryTree;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTreeNode_WhenMaxDepth_ThenResultAsExpected(TreeNode root, int expected)
    {
        Solution.MaxDepth(root).ShouldBe(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        //   1
        //    \
        //     2
        var root = new TreeNode(1)
        {
            Left = null,
            Right = new TreeNode(2)
        };
        yield return [root, 2];

        //    3
        //   / \
        //  9   20
        //      /\
        //    15  7
        root = new TreeNode(3)
        {
            Left = new TreeNode(9),
            Right = new TreeNode(20)
            {
                Left = new TreeNode(15),
                Right = new TreeNode(7)
            }
        };
        yield return [root, 3];

        //      5
        //    /  \
        //   2   10
        //  /   /  \
        // 1   8   20
        //           \
        //           30
        root = new TreeNode(5)
        {
            Left = new TreeNode(2) { Left = new TreeNode(1) },
            Right = new TreeNode(10)
            {
                Left = new TreeNode(8),
                Right = new TreeNode(20) { Right = new TreeNode(30) }
            }
        };
        yield return [root, 4];

        //      5
        //    /  \
        //   2   10
        //  /   /  \
        // 1   8   20
        //    /      \
        //   6       30
        root = new TreeNode(5)
        {
            Left = new TreeNode(2) { Left = new TreeNode(1) },
            Right = new TreeNode(10)
            {
                Left = new TreeNode(8) { Left = new TreeNode(6) },
                Right = new TreeNode(20) { Right = new TreeNode(30) }
            }
        };
        yield return [root, 4];
    }
}
