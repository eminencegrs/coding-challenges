using LeetCode.Challenges.Problems00xx.N_0046_Permutations;
using Shouldly;
using Xunit;

namespace LeetCode.Challenges.UnitTests.Problems00xx.N_0046_Permutations;

public class OptimizedSolutionTests
{
    [Theory]
    [ClassData(typeof(TestData))]
    public void GivenNumbers_WhenPermute_ThenResultAsExpected(int[] numbers, IList<IList<int>> expectedResult)
    {
        OptimizedSolution.Permute(numbers).ShouldBeEquivalentTo(expectedResult);
    }
}