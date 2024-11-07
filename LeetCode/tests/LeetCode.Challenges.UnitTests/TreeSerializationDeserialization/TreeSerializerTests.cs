using LeetCode.Challenges.TreeSerializationDeserialization;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TreeSerializationDeserialization;

public class TreeSerializerTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTree_WhenSerialize_ThenStringAsExpected(TreeNode root, string expectedResult)
    {
        var actualResult = new TreeSerializer().Serialize(root);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // The test tree:
        //       5
        //     /   \
        //    3     2
        //   / \   / \
        //  @  4  @   @
        //    / \
        //   @   @

        var root = new TreeNode
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

        yield return [root, "5;3;@;4;@;@;2;@;@"];
        yield return [new TreeNode { Value = 1 }, "1;@;@"];
        yield return [null!, "@"];
    }
}
