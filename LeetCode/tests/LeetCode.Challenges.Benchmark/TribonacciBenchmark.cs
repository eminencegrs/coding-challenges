using BenchmarkDotNet.Attributes;
using LeetCode.Challenges.Tribonacci;

namespace LeetCode.Challenges.Benchmark;

public class TribonacciBenchmark
{
    private readonly IterativeSolution iterativeSolution = new();
    private readonly RecursiveSolutionWithCache recursiveSolutionWithCache = new();

    [Params(0, 1, 2, 3, 4, 5, 10, 20)]
    public int N { get; set; }

    [Benchmark]
    public int IterativeSolutionBenchmark()
    {
        return this.iterativeSolution.Tribonacci(this.N);
    }

    [Benchmark]
    public int RecursiveSolutionWithCacheBenchmark()
    {
        return this.recursiveSolutionWithCache.Tribonacci(this.N);
    }
}
