using LeetCode.Challenges.TreeSerializationDeserialization;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TreeSerializationDeserialization;

public class TreeDeserializerTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenDeserialize_ThenTreeAsExpected(string inputString, TreeNode expectedResult)
    {
        var cut = new TreeDeserializer(inputString);
        var actualResult = cut.Deserialize(inputString);
        actualResult.ShouldBeEquivalentTo(expectedResult);
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

        yield return ["5;3;@;4;@;@;2;@;@", root];
    }
}
