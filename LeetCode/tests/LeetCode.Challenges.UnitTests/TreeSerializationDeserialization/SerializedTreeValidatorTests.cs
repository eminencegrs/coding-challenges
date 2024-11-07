using LeetCode.Challenges.TreeSerializationDeserialization;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.TreeSerializationDeserialization;

public class SerializedTreeValidatorTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenValidateIfPreOrderTraversal_ThenResultAsExpected(
        string inputString, bool expectedResult)
    {
        var cut = new SerializedTreeValidator();
        var actualResult = cut.ValidateIfPreOrderTraversal(inputString);
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

        yield return ["5;3;@;4;@;@;2;@;@", true];
        yield return ["1;@;@", true];
        yield return ["@", true];
        yield return ["", false];
        yield return ["@;@", false];
    }
}
