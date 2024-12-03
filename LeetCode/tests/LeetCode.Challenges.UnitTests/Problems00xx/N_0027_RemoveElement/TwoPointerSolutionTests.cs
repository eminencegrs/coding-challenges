using FluentAssertions;
using FluentAssertions.Execution;
using LeetCode.Challenges.Problems00xx.N_0027_RemoveElement;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0027_RemoveElement;

public class TwoPointerSolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbersAndValue_WhenRemoveElement_ThenResultAsExpected(
        int[] numbers, int value, int[] expectedArray, int expectedCount)
    {
        var actualCount = TwoPointerSolution.RemoveElement(numbers, value);
        using (new AssertionScope())
        {
            actualCount.Should().Be(expectedCount);
            numbers.Should().BeEquivalentTo(expectedArray);
        }
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return [new[] { 1 }, 1, new[] { 1 }, 0];
        yield return [new[] { 3, 2, 2, 3 }, 3, new[] { 2, 2, 3, 3 }, 2];
        yield return [new[] { 2, 2, 3 }, 2, new[] { 3, 2, 2 }, 1];
        yield return
        [
            new[] { 4, 2, 0, 2, 2, 1, 4, 4, 1, 4, 3, 2 },
            4,
            new[] { 2, 2, 0, 2, 2, 1, 3, 1, 4, 4, 4, 4 },
            8
        ];
    }
}
