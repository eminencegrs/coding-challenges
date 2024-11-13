using LeetCode.Challenges.Problems01xx.P0100_SameTree;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems01xx.P0100_SameTree;

public class TreeSerializerTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTree_WhenSerialize_ThenStringAsExpected(
        TreeNode first, TreeNode second, bool expectedResult)
    {
        Solution.IsSameTree(first, second).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // The test trees:
        //       1            1
        //     /  \         /  \
        //    2    3       2    3

        var first = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 2 },
            Right = new TreeNode { Value = 3 }
        };

        var second = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 2 },
            Right = new TreeNode { Value = 3 }
        };

        yield return [first, second, true];

        // The test trees:
        //       1            1
        //     /               \
        //    2                 2

        first = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 2 }
        };

        second = new TreeNode
        {
            Value = 1,
            Right = new TreeNode { Value = 2 }
        };

        yield return [first, second, false];

        // The test trees:
        //       1            1
        //     /  \         /  \
        //    2    1       1    2

        first = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 2 },
            Right = new TreeNode { Value = 1 }
        };

        second = new TreeNode
        {
            Value = 1,
            Left = new TreeNode { Value = 1 },
            Right = new TreeNode { Value = 2 }
        };

        yield return [first, second, false];

        // The test trees:
        //       3            3
        //     /  \         /  \
        //    2    5       2    5
        //   /    / \     /    / \
        //  1    4   6   1    4   6

        first = new TreeNode
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

        second = new TreeNode
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

        yield return [first, second, true];

        // The test trees:
        //       3            3
        //     /  \         /  \
        //    2    5       2    5
        //   /    / \     /    / \
        //  1    4   6   1    4   7

        first = new TreeNode
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

        second = new TreeNode
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
                Right = new TreeNode { Value = 7 }
            }
        };

        yield return [first, second, false];

        // The test trees:
        //       3            3
        //     /  \         /  \
        //    2    5       2    5
        //   /    /       /    / \
        //  1    4       1    4   6

        first = new TreeNode
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
                Left = new TreeNode { Value = 4 }
            }
        };

        second = new TreeNode
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

        yield return [first, second, false];
    }
}
