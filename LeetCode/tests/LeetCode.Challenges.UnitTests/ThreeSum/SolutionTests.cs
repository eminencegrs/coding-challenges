using LeetCode.Challenges.ThreeSum;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.ThreeSum;

public class SolutionTests
{
    [Theory]
    [MemberData(nameof(TestData))]
    public void GivenNumbers_WhenCallGetResult_ThenResultAsExpected(int[] numbers, int[][] expectedResult)
    {
        var actualResult = Solution.GetResult(numbers);
        actualResult.Count.ShouldBeEquivalentTo(expectedResult.Length);
        for (int i = 0; i < expectedResult.Length; i++)
        {
            actualResult[i].ShouldBe(expectedResult[i]);
        }
    }

    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new[] { -1, 0, 1, 2, -1, -4 },
            new[] { new[] { -1, -1, 2 }, new[] { -1, 0, 1 } }
        };
    }
}
