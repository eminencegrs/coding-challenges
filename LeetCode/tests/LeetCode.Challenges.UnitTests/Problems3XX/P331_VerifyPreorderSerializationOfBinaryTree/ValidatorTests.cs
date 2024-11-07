using LeetCode.Challenges.Problems3XX.P331_VerifyPreorderSerializationOfBinaryTree;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems3XX.P331_VerifyPreorderSerializationOfBinaryTree;

public class ValidatorTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenString_WhenIsValidSerialization_ThenResultAsExpected(string inputString, bool expectedResult)
    {
        var actualResult = Validator.IsValidSerialization(inputString);
        actualResult.ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        // Leetcode test cases:
        yield return ["9,3,4,#,#,1,#,#,2,#,6,#,#", true];
        yield return ["1,#", false];
        yield return ["9,#,#,1", false];

        // My custom test cases:
        yield return ["1,#,#", true];
        yield return ["#", true];
        yield return ["", false];
        yield return ["#,#", false];
        yield return ["5,3,#,4,#,#,2,#,#", true];

        // The last test case's tree:
        //       5
        //     /   \
        //    3     2
        //   / \   / \
        //  #  4  #   #
        //    / \
        //   #   #
    }
}
