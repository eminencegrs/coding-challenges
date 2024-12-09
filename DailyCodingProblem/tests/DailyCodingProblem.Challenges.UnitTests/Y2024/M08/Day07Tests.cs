using DailyCodingProblem.Challenges.Y2024.M08;
using Shouldly;
using Xunit;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M08;

public class Day07Tests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenGetResultByUsingBruteForce_ThenResultAsExpected(
        int[][] numbers, int expectedResult)
    {
        Day07Task.GetMinNumberOfRooms(numbers).ShouldBe(expectedResult);
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new int[][] { [30, 75], [0, 50], [60, 150] }, 2];
        yield return [new int[][] { [0, 30], [35, 50], [55, 70] }, 1];
        yield return [new int[][] { [10, 20], [10, 30], [10, 40] }, 3];
        yield return [new int[][] { [0, 10], [10, 20], [20, 30] }, 1];
        yield return [new int[][] { }, 0];
        yield return [new int[][] { [5, 10] }, 1];
        yield return [new int[][] { [0, 100], [50, 150], [75, 125] }, 3];
        yield return [new int[][] { [5, 10], [10, 20], [15, 25], [30, 40] }, 2];

        // LeetCode: #2406 - Divide Intervals Into Minimum Number of Groups.
        yield return [new int[][] { [5, 10], [6, 8], [1, 5], [2, 3], [1, 10] }, 3];
        yield return [new int[][] { [1, 3], [5, 6], [8, 10], [11, 13] }, 1];
    }
}
