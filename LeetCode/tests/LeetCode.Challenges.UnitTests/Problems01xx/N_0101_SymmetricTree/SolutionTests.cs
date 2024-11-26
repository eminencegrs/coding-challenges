using LeetCode.Challenges.Problems01xx.N_0101_SymmetricTree;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems01xx.N_0101_SymmetricTree;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTree_WhenIsSymmetric_ThenResultAsExpected(TreeNode root, bool expectedResult)
    {
        Solution.IsSymmetric(root).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [null!, true];

        yield return [new TreeNode(), true];

        // The test tree:
        //       1
        //     /  \
        //    2    3
        var root = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 2 },
            Right = new TreeNode { Value = 3 }
        };

        yield return [root, false];

        // The test trees:
        //       1
        //     /  \
        //    2    2
        root = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 2 },
            Right = new TreeNode { Value = 2 }
        };

        yield return [root, true];

        // The test trees:
        //       1
        //     /
        //    2
        root = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 2 }
        };

        yield return [root, false];

        // The test trees:
        //       1
        //        \
        //         2
        root = new TreeNode
        {
            Value = 1,
            Right = new TreeNode { Value = 2 }
        };

        yield return [root, false];

        // The test trees:
        //       3
        //     /  \
        //    2    5
        //   /    / \
        //  1    4   6
        root = new TreeNode
        {
            Value = 3,
            Left = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 1 }
            },
            Right = new TreeNode
            {
                Value = 5,
                Left = new TreeNode { Value = 4 },
                Right = new TreeNode { Value = 6 }
            }
        };

        yield return [root, false];

        // The test trees:
        //       1
        //     /   \
        //    2     2
        //   / \   / \
        //  3  4  4   3
        root = new TreeNode
        {
            Value = 1,
            Left = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 3 },
                Right = new TreeNode { Value = 4 }
            },
            Right = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 4 },
                Right = new TreeNode { Value = 3 }
            }
        };

        yield return [root, true];
    }
}
