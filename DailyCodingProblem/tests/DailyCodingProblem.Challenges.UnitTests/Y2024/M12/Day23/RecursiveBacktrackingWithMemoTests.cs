using Shouldly;
using Xunit;
using DailyCodingProblem.Challenges.Y2024.M12.Day23;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M12.Day23;

public class RecursiveBacktrackingWithMemoTests
{
    [Theory]
    [MemberData(nameof(GetPathsTestData))]
    public void GivenMatrix_WhenGetPaths_ThenResultAsExpected(int[][] matrix, int expectedPaths)
    {
        RecursiveBacktrackingWithMemo.GetPaths(matrix).ShouldBe(expectedPaths);
    }

    public static IEnumerable<object[]> GetPathsTestData()
    {
        return new List<object[]>
        {
            new object[]
            {
                new int[][]
                {
                    new int[] { 0, 0, 1 },
                    new int[] { 0, 0, 1 },
                    new int[] { 1, 0, 0 }
                },
                2
            },
            new object[]
            {
                new[]
                {
                    [0, 1],
                    new[] { 1, 0 }
                },
                0
            },
            new object[]
            {
                new[]
                {
                    new[] { 0 }
                },
                1
            },
            new object[]
            {
                new[]
                {
                    [0, 0, 0],
                    [1, 1, 0],
                    new[] { 0, 0, 0 }
                },
                1
            },
            new object[]
            {
                new[]
                {
                    [0, 1, 1],
                    [1, 1, 1],
                    new[] { 1, 1, 0 }
                },
                0
            }
        };
    }
}
