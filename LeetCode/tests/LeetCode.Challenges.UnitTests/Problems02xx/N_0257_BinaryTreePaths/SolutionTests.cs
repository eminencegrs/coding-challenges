using FluentAssertions;
using LeetCode.Challenges.Problems02xx.N_0257_BinaryTreePaths;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems02xx.N_0257_BinaryTreePaths;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTree_WhenSerialize_ThenStringAsExpected(TreeNode root, IList<string> expectedResult)
    {
        Solution.BinaryTreePaths(root).Should().BeEquivalentTo(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [null!, Enumerable.Empty<string>().ToList()];

        yield return [new TreeNode { Value = 1 }, new[] { "1" }];

        var root = new TreeNode
        {
            Value = 1,
            Left = new TreeNode
            {
                Value = 2,
                Left = null,
                Right = new TreeNode { Value = 5 }
            },
            Right = new TreeNode { Value = 3 }
        };

        yield return [root, new[] { "1->2->5", "1->3" }];

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

        yield return [root, new[] { "10->20->30", "10->20->30", "10->20->30", "10->20->30" }];
    }
}
