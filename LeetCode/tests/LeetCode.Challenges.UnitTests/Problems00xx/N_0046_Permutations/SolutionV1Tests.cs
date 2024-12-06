using LeetCode.Challenges.Problems00xx.N_0046_Permutations;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0046_Permutations;

public class SolutionV1Tests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenPermute_ThenResultAsExpected(int[] numbers, IList<IList<int>> expectedResult)
    {
        SolutionV1.Permute(numbers).ShouldBeEquivalentTo(expectedResult);
    }
}
