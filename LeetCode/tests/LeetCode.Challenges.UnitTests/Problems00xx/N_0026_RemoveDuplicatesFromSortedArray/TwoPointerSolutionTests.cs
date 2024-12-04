using FluentAssertions;
using FluentAssertions.Execution;
using LeetCode.Challenges.Problems00xx.N_0026_RemoveDuplicatesFromSortedArray;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0026_RemoveDuplicatesFromSortedArray;

public class TwoPointerSolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenRemoveDuplicates_ThenResultAsExpected(
        int[] numbers, int[] expectedArray, int expectedCount)
    {
        var actualCount = TwoPointerSolution.RemoveDuplicates(numbers);
        using (new AssertionScope())
        {
            actualCount.Should().Be(expectedCount);
            numbers.Should().BeEquivalentTo(expectedArray);
        }
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 1 }, new[] { 1 }, 1];
        yield return [new[] { 1, 1, 2 }, new[] { 1, 2, 2 }, 2];
        yield return [new[] { 1, 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 5 }, 5];
        yield return [new[] { 0, 1, 2, 3, 4, 5, 5 }, new[] { 0, 1, 2, 3, 4, 5, 5 }, 6];
        yield return [new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new[] { 0, 1, 2, 3, 4, 2, 2, 3, 3, 4 }, 5];
        yield return [new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10];
    }
}
