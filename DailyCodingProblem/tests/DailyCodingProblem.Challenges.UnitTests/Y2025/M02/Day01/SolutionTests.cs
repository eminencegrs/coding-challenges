using DailyCodingProblem.Challenges.Y2025.M02.Day01;
using Shouldly;
using Xunit;
using TreeNode = DailyCodingProblem.Challenges.Y2025.M01.Day31.TreeNode;

namespace DailyCodingProblem.Challenges.UnitTests.Y2025.M02.Day01;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenArrayOfNumbers_WhenRotate_ThenResultAsExpected(
        int[] numbers, int step, string direction, int[] expected)
    {
        Solution.Rotate(numbers, step, direction);
        numbers.ShouldBeEquivalentTo(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 1, 2, 3, 4, 5 }, 2, "right", new[] { 4, 5, 1, 2, 3 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 3, "right", new[] { 3, 4, 5, 1, 2 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 2, "left", new[] { 3, 4, 5, 1, 2 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 3, "left", new[] { 4, 5, 1, 2, 3 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 5, "left", new[] { 1, 2, 3, 4, 5 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 5, "right", new[] { 1, 2, 3, 4, 5 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 6, "left", new[] { 2, 3, 4, 5, 1 }];
        yield return [new[] { 1, 2, 3, 4, 5 }, 6, "right", new[] { 5, 1, 2, 3, 4 }];
    }
}
