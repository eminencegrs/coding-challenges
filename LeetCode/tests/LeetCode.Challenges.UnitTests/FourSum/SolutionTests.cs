using LeetCode.Challenges.FourSum;
using FluentAssertions;
using Xunit;

namespace LeetCode.Challenges.UnitTests.FourSum;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenCallGetResult_ThenResultAsExpected(
        long[] numbers, long target, List<List<long>> expectedResult)
    {
        var actualResult = Solution.GetResult(numbers, target);
        actualResult.Count.Should().Be(expectedResult.Count);

        // Sorting both actual and expected results for comparison.
        var sortedActualResult = actualResult
            .Select(quadruplet => quadruplet.OrderBy(x => x).ToList())
            .OrderBy(quadruplet => quadruplet, new ListComparer<long>())
            .ToList();

        var sortedExpectedResult = expectedResult
            .Select(quadruplet => quadruplet.OrderBy(x => x).ToList())
            .OrderBy(quadruplet => quadruplet, new ListComparer<long>())
            .ToList();

        sortedActualResult.Should().BeEquivalentTo(
            sortedExpectedResult,
            options => options.WithStrictOrdering());
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return
        [
            new long[] { 1, 0, -1, 0, -2, 2 },
            0L,
            new List<List<long>>
            {
                new() { -2, -1, 1, 2 },
                new() { -1,  0, 0, 1 },
                new() { -2,  0, 0, 2 }
            }
        ];

        yield return
        [
            new long[] { 2, 2, 2, 2 },
            8L,
            new List<List<long>> { new() { 2, 2, 2, 2 } }
        ];

        yield return
        [
            new long[] { -3, -2, -1, 0, 0, 1, 2, 3 },
            0L,
            new List<List<long>>
            {
                new() { -3, -2, 2, 3 },
                new() { -3, -1, 1, 3 },
                new() { -3, 0, 0, 3 },
                new() { -3, 0, 1, 2 },
                new() { -2, -1, 0, 3 },
                new() { -2, -1, 1, 2 },
                new() { -2, 0, 0, 2 },
                new() { -1, 0, 0, 1 }
            }
        ];

        yield return
        [
            new long[] { 1000000000, 1000000000, 1000000000, 1000000000 },
            -294967296L,
            new List<List<long>>()
        ];
    }

    private class ListComparer<T> : IComparer<IList<T>> where T : IComparable<T>
    {
        public int Compare(IList<T>? x, IList<T>? y)
        {
            if (x is null || y is null)
            {
                throw new ArgumentNullException();
            }

            int lengthComparison = x.Count.CompareTo(y.Count);
            if (lengthComparison != 0)
            {
                return lengthComparison;
            }

            for (int i = 0; i < x.Count; i++)
            {
                int itemComparison = x[i].CompareTo(y[i]);
                if (itemComparison != 0)
                {
                    return itemComparison;
                }
            }

            return 0;
        }
    }
}
