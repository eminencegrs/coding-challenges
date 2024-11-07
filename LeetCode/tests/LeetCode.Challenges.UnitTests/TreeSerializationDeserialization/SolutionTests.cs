using LeetCode.Challenges.TreeSerializationDeserialization;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TreeSerializationDeserialization;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestTree))]
    public void GivenTree_WhenSerialize_ThenStringAsExpected(TreeNode root, string expectedResult)
    {
        var actualResult = new Solution().Serialize(root);
        actualResult.ShouldBe(expectedResult);
    }

    [Theory]
    [ClassData(typeof(TestString))]
    public void GivenString_WhenDeserialize_ThenTreeAsExpected(string tree, TreeNode expectedResult)
    {
        var action = () => new Solution().Deserialize(tree);
        action.ShouldThrow<NotImplementedException>();
    }
}
