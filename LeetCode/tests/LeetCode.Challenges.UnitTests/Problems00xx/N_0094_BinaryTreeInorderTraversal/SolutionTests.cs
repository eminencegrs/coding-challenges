using LeetCode.Challenges.Problems00xx.N_0094_BinaryTreeInorderTraversal;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0094_BinaryTreeInorderTraversal;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTree_WhenInorderTraversal_ThenResultAsExpected(TreeNode root, IList<int> expectedResult)
    {
        var actualResult = new Solution().InorderTraversal(root);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // The test tree:
        //       1
        //        \
        //         2
        //        /
        //       3

        var root = new TreeNode
        {
            Value = 1,
            Right = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 3 }
            }
        };

        yield return [root, new List<int> { 1, 3, 2 }];

        // The test tree:
        //       5
        //     /   \
        //    3     2
        //     \
        //     4

        root = new TreeNode
        {
            Value = 5,
            Left = new TreeNode
            {
                Value = 3,
                Left = null,
                Right = new TreeNode { Value = 4 }
            },
            Right = new TreeNode { Value = 2 }
        };

        yield return [root, new List<int> { 3, 4, 5, 2 }];

        // The test tree:
        //           1
        //         /   \
        //        2     3
        //       / \     \
        //      4   5     8
        //         / \   /
        //        6   7 9

        root = new TreeNode
        {
            Value = 1,
            Left = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 4 },
                Right = new TreeNode
                {
                    Value = 5,
                    Left = new TreeNode { Value = 6 },
                    Right = new TreeNode { Value = 7 }
                }
            },
            Right = new TreeNode
            {
                Value = 3,
                Right = new TreeNode
                {
                    Value = 8,
                    Left = new TreeNode { Value = 9 }
                }
            }
        };

        yield return [root, new List<int> { 4, 2, 6, 5, 7, 1, 3, 9, 8 }];

        // An empty tree: root is null.
        yield return [null!, Enumerable.Empty<int>().ToList()];

        yield return [new TreeNode { Value = 1 }, new List<int> { 1 }];
    }
}
