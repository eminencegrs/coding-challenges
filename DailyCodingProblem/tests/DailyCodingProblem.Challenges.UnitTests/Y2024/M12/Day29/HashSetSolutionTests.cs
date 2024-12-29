using Xunit;
using DailyCodingProblem.Challenges.Y2024.M12.Day29;
using Shouldly;

namespace DailyCodingProblem.Challenges.UnitTests.Y2024.M12.Day29;

public class HashSetSolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GetFirstRecurringChar_ShouldReturnExpectedResult(int[] numbers, int expected)
    {
        HashSetSolution.FindDuplicate(numbers).ShouldBe(expected);
    }

    public static IEnumerable<object[]> TestData()
    {
        return new List<object[]>
        {
            new object[] { new[] { 1, 2, 3, 5, 5 }, 5 },
            new object[] { new[] { 1, 1, 2, 3, 4 }, 1 },
            new object[] { new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 }, 1 },
        };
    }
}
