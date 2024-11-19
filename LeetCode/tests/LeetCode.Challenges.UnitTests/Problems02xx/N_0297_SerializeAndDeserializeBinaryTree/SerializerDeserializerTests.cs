using LeetCode.Challenges.Problems02xx.N_0297_SerializeAndDeserializeBinaryTree;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems02xx.N_0297_SerializeAndDeserializeBinaryTree;

public class SerializerDeserializerTests
{
    [Theory]
    [MemberData(nameof(TestDataForSerialization))]
    public void GivenTree_WhenSerialize_ThenStringAsExpected(TreeNode node, string expectedResult)
    {
        var cut = new SerializerDeserializer();
        var actualResult = cut.Serialize(node);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    [Theory]
    [MemberData(nameof(TestDataForDeserialization))]
    public void GivenString_WhenDeserialize_ThenTreeAsExpected(string serializedTree, TreeNode expectedResult)
    {
        var cut = new SerializerDeserializer();
        var actualResult = cut.Deserialize(serializedTree);
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenTree_WhenSerializeAndDeserialize_ThenResultAsExpected(TreeNode node, TreeNode expectedResult)
    {
        var serializer = new SerializerDeserializer();
        var deserializer = new SerializerDeserializer();
        var actualResult = deserializer.Deserialize(serializer.Serialize(node));
        actualResult.ShouldBeEquivalentTo(expectedResult);
    }

    // Please, note: the following tree is used for all the test cases.
    //   1
    //  / \
    // 2   3
    //    / \
    //   4   5

    public static IEnumerable<object[]> TestDataForSerialization()
    {
        var root = new TreeNode(1)
        {
            Left = new TreeNode(2),
            Right = new TreeNode(3)
            {
                Left = new TreeNode(4),
                Right = new TreeNode(5)
            }
        };

        yield return [root, "1;2;3;;;4;5"];
        yield return [null!, ""];
    }

    public static IEnumerable<object[]> TestDataForDeserialization()
    {
        var root = new TreeNode(1)
        {
            Left = new TreeNode(2),
            Right = new TreeNode(3)
            {
                Left = new TreeNode(4),
                Right = new TreeNode(5)
            }
        };

        yield return ["1;2;3;;;4;5", root];
        yield return ["", null!];
    }

    public static IEnumerable<object[]> TestData()
    {
        var input = new TreeNode(1)
        {
            Left = new TreeNode(2),
            Right = new TreeNode(3)
            {
                Left = new TreeNode(4),
                Right = new TreeNode(5)
            }
        };

        var output = new TreeNode(1)
        {
            Left = new TreeNode(2),
            Right = new TreeNode(3)
            {
                Left = new TreeNode(4),
                Right = new TreeNode(5)
            }
        };

        yield return [input, output];
        yield return [null!, null!];
    }
}
