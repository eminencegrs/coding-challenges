using DailyCodingProblem.Challenges.Y2025.M01.Day31;
using Shouldly;
using Xunit;
using TreeNode = DailyCodingProblem.Challenges.Y2025.M01.Day31.TreeNode;

namespace DailyCodingProblem.Challenges.UnitTests.Y2025.M01.Day31;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTreeNode_WhenFindTheMostFrequentSubtreeSum_ThenResultAsExpected(TreeNode root, int expected)
    {
        Solution.FindTheMostFrequentSubtreeSum(root).ShouldBeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [null!, 0];

        //     5
        //    / \
        //   2   -5
        var root = new TreeNode(5)
        {
            Left = new TreeNode(2),
            Right = new TreeNode(-5)
        };

        yield return [root, 2];

        //     -1
        //    /  \
        //   0    0
        root = new TreeNode(-1)
        {
            Left = new TreeNode(0),
            Right = new TreeNode(0)
        };

        //      7
        //    /   \
        //   5    -6
        //  / \   / \
        // 3  -2 -4  3
        root = new TreeNode(7)
        {
            Left = new TreeNode(5)
            {
                Left = new TreeNode(3),
                Right = new TreeNode(-2)
            },
            Right = new TreeNode(-6)
            {
                Left = new TreeNode(-4),
                Right = new TreeNode(3)
            }
        };

        yield return [root, 3];
    }
}
