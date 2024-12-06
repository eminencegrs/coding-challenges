using BenchmarkDotNet.Attributes;
using LeetCode.Challenges.Problems00xx.N_0046_Permutations;

namespace LeetCode.Challenges.Benchmark.N_0046_Permutations;

public class PermutationsBenchmark
{
    private readonly int[] smallInput = [1, 2, 3];
    private readonly int[] midInput = [1, 2, 3, 4, 5];

    [Benchmark]
    public IList<IList<int>> SolutionV1SmallInput()
    {
        return SolutionV1.Permute(this.smallInput);
    }

    [Benchmark]
    public IList<IList<int>> OptimizedSolutionSmallInput()
    {
        return OptimizedSolution.Permute(this.smallInput);
    }

    [Benchmark]
    public IList<IList<int>> SolutionV1MidInput()
    {
        return SolutionV1.Permute(this.midInput);
    }

    [Benchmark]
    public IList<IList<int>> OptimizedSolutionMidInput()
    {
        return OptimizedSolution.Permute(this.midInput);
    }
}
