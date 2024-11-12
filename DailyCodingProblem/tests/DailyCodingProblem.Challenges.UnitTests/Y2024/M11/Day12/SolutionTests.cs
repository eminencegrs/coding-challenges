using DailyCodingProblem.Challenges.Y2024.M11.Day12;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M11.Day12;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTree_WhenGetTreeLevelWithMinSum_ThenResultAsExpected(TreeNode root, int expected)
    {
        Solution.GetTreeLevelWithMinSum(root).ShouldBe(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        var root = new TreeNode(9)
        {
            Left = new TreeNode(5)
            {
                Left = new TreeNode(1),
                Right = new TreeNode(2),
            },
            Right = new TreeNode(10)
            {
                Left = new TreeNode(3)
            }
        };
        yield return [root, 2];

        yield return [new TreeNode(5), 0];
        
        root = new TreeNode(3)
        {
            Left = new TreeNode(-1),
            Right = new TreeNode(-2)
        };
        yield return [root, 1];

        root = new TreeNode(1)
        {
            Left = new TreeNode(2)
            {
                Left = new TreeNode(4),
                Right = new TreeNode(5),
            },
            Right = new TreeNode(3)
            {
                Left = new TreeNode(6),
                Right = new TreeNode(7),
            }
        };
        yield return [root, 0];

        root = new TreeNode(2)
        {
            Left = new TreeNode(2),
            Right = new TreeNode(2)
            {
                Left = new TreeNode(2),
                Right = new TreeNode(2),
            }
        };
        yield return [root, 0];

        root = new TreeNode(1)
        {
            Left = new TreeNode(7)
            {
                Left = new TreeNode(0),
                Right = new TreeNode(-4)
            },
            Right = new TreeNode(-3)
        };
        yield return [root, 2];

        root = new TreeNode(10)
        {
            Left = new TreeNode(5)
            {
                Left = new TreeNode(4)
                {
                    Left = new TreeNode(1)
                    {
                        Left = new TreeNode(-6)
                    }
                }
            }
        };
        yield return [root, 4];

        //           -5
        //       -10     -15
        //    -20  -30  -25  -35
        root = new TreeNode(-5)
        {
            Left = new TreeNode(-10)
            {
                Left = new TreeNode(-20),
                Right = new TreeNode(-30)
            },
            Right = new TreeNode(-15)
            {
                Left = new TreeNode(-25),
                Right = new TreeNode(-35)
            }
        };
        yield return [root, 2];
    }
}
