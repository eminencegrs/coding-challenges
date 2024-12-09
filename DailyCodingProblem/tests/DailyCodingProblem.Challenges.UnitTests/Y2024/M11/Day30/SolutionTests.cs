using DailyCodingProblem.Challenges.Y2024.M11.Day30;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M11.Day30;

public class SolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenTreeNode_WhenFindMinPathSum_ThenResultAsExpected(TreeNode root, int expectedResult)
    {
        Solution.FindMinPathSum(root).ShouldBe(expectedResult);
    }
}
