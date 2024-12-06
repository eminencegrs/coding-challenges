using BenchmarkDotNet.Attributes;
using LeetCode.Challenges.Problems11xx.N_1137_NthTribonacciNumber;

namespace LeetCode.Challenges.Benchmark;

public class TribonacciBenchmark
{
    [Params(0, 1, 2, 3, 4, 5, 10, 20)]
    public int N { get; set; }

    [Benchmark]
    public int IterativeSolutionBenchmark()
    {
        return IterativeSolution.Tribonacci(this.N);
    }

    [Benchmark]
    public int RecursiveSolutionWithCacheBenchmark()
    {
        return RecursiveSolutionWithCache.Tribonacci(this.N);
    }
}
