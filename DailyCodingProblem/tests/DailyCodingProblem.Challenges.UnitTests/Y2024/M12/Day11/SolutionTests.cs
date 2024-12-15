using DailyCodingProblem.Challenges.Y2024.M12.Day11;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M12.Day11;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTreeNode_WhenPruneTree_ThenResultAsExpected(TreeNode root, TreeNode expected)
    {
        Solution.PruneTree(root).ShouldBeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [null!, null!];

        //     0
        //    / \
        //   1   0
        //      / \
        //     1   0
        //    / \
        //   0   0
        var root = new TreeNode(0)
        {
            Left = new TreeNode(1),
            Right = new TreeNode(0)
            {
                Left = new TreeNode(1)
                {
                    Left = new TreeNode(0),
                    Right = new TreeNode(0)
                },
                Right = new TreeNode(0)
            }
        };

        //     0
        //    / \
        //   1   0
        //      /
        //     1
        var expected = new TreeNode(0)
        {
            Left = new TreeNode(1),
            Right = new TreeNode(0)
            {
                Left = new TreeNode(1)
            }
        };

        yield return [root, expected];

        yield return [new TreeNode(0), null!];

        yield return [new TreeNode(1), new TreeNode(1)];

        root = new TreeNode(0)
        {
            Left = new TreeNode(0),
            Right = new TreeNode(0)
        };

        yield return [root, null!];

        root = new TreeNode(0)
        {
            Left = new TreeNode(0),
            Right = new TreeNode(0)
        };

        yield return [root, null!];

        root = new TreeNode(1)
        {
            Left = new TreeNode(1),
            Right = new TreeNode(1)
        };

        expected = new TreeNode(1)
        {
            Left = new TreeNode(1),
            Right = new TreeNode(1)
        };

        yield return [root, expected];
    }
}
