using System.Collections;
using DailyCodingProblem.Challenges.Y2024.M11.Day30;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M11.Day30;

public class TestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [null!, 0];

        yield return [new TreeNode(), 0];

        yield return [new TreeNode { Value = int.MaxValue }, int.MaxValue];

        yield return [new TreeNode { Value = int.MinValue }, int.MinValue];

        // The test tree:
        //       10
        //     /   \
        //    5     5
        //     \     \
        //      2     1
        //           /
        //         -1

        var root = new TreeNode
        {
            Value = 10,
            Left = new TreeNode
            {
                Value = 5,
                Right = new TreeNode { Value = 2 }
            },
            Right = new TreeNode
            {
                Value = 5,
                Right = new TreeNode
                {
                    Value = 1,
                    Left = new TreeNode { Value = -1 }
                }
            }
        };

        yield return [root, 15];

        // The test tree:
        //       5
        //     /  \
        //    3    2
        //     \
        //     2

        root = new TreeNode
        {
            Value = 5,
            Left = new TreeNode
            {
                Value = 3,
                Right = new TreeNode { Value = 2 }
            },
            Right = new TreeNode { Value = 2 }
        };

        yield return [root, 7];

        // The test tree:
        //       10
        //     /   \
        //    20    20
        //   / \    / \
        //  30 30  30 30

        root = new TreeNode
        {
            Value = 10,
            Left = new TreeNode
            {
                Value = 20,
                Left = new TreeNode { Value = 30 },
                Right = new TreeNode { Value = 30 }
            },
            Right = new TreeNode
            {
                Value = 20,
                Left = new TreeNode { Value = 30 },
                Right = new TreeNode { Value = 30 }
            }
        };

        yield return [root, 60];

        // The test tree:
        //        1
        //     /    \
        //    2      2
        //   / \    / \
        //  4   3  3   4
        //   \        /
        //   -2      -3

        root = new TreeNode
        {
            Value = 1,
            Left = new TreeNode
            {
                Value = 2,
                Left = new TreeNode
                {
                    Value = 4,
                    Right = new TreeNode { Value = -2 }
                },
                Right = new TreeNode { Value = 3 }
            },
            Right = new TreeNode
            {
                Value = 2,
                Left = new TreeNode { Value = 3 },
                Right = new TreeNode
                {
                    Value = 4,
                    Left = new TreeNode { Value = -3 }
                }
            }
        };

        yield return [root, 4];
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
